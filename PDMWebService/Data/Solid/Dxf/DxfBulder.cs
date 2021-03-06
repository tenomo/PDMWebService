﻿//using PDMWebService.Data.PDM;
//using PDMWebService.Properties;
//using ServiceLibrary.DataContracts;
//using SolidWorks.Interop.sldworks;
//using SolidWorks.Interop.swconst;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;

//namespace PDMWebService.Data.Solid.Dxf
//{
//    public class DxfBulder :Singleton.AbstractSingeton<DxfBulder>
//    {
//        private DxfBulder( ) : base()
//        {
//            this.solidWorksApp = SolidWorksInstance.SldWoksApp;
//            Pdm = SolidWorksPdmAdapter.Instance;
//            FolderToSaveDxf = @"D:\TEMP\dxf\";
//        }
//        private   SldWorks solidWorksApp;
//        private Settings Settings
//        {
//            get
//            {
//                return Settings.Default;
//            }
//        }
//        public IPdmAdapter Pdm { get; set; }

//        private string FolderToSaveDxf { get; set; }


//        public delegate void ToSqlHandler (  List<DxfFile> dxfList );
//        public event ToSqlHandler ToSql;

//        public  void Build(DataModel dataModel )
//        {  
//            List<DxfFile> dxfList = new List<DxfFile>(); 
//         //   foreach (var eachConfiguration in configurations)
//          //  { 
//                CeateDxf(dataModel.Path, dataModel.Id, dataModel.CurrentVersion, ref dxfList, true, true, false);          
                                    
//           // }
//            if (ToSql != null && dxfList.Count >0)
//                ToSql(dxfList);
//        }
 



//        private bool CeateDxf(string partPath,/* string folderToSave , string configuration ,*/ int idPdm, int version, ref List<DxfFile> dxfList, bool fixBends, bool closeAfterSave, bool includeNonSheetParts /*Включить не листовые детали*/)
//        {
//            int error = 0, warnings= 0;
//            bool isSave = false;
//            if (dxfList == null)
//                dxfList = new List<DxfFile>();
//            //if (string.IsNullOrEmpty(FolderToSaveDxf))
//            //{
//            //    FolderToSaveDxf = Settings.DefaultFolderForDxf;
//            //}
//            try
//            {
//                IModelDoc2 swModel = null;
//                if (!string.IsNullOrEmpty(partPath))
//                {

//                    try
//                    {
//                        string noConfiguration = "";
//                        swModel = solidWorksApp.OpenDoc6(partPath, (int)swDocumentTypes_e.swDocPART, (int)swOpenDocOptions_e.swOpenDocOptions_Silent, noConfiguration, error, warnings);
//                        swModel = solidWorksApp.IActiveDoc2; // ??

//                        // Проверяет наличие дерева постоения в моделе.
//                        if (swModel == null)
//                        {
//                            return isSave;
//                        }
//                    }
//                    catch (Exception exception)
//                    {
//                        throw new Exception("Failed open document: " + exception.ToString());
//                    }
//                }
//                //else
//                //{
//                //    swModel = solidWorksApp.IActiveDoc2;
//                //}



//                bool isSheetmetal = true;

//                if (!SolidWorksInstance.IsSheetMetalPart((IPartDoc)swModel))
//                {
//                    isSheetmetal = false;
//                    if (!includeNonSheetParts)
//                    { 

//                        SolidWorksInstance.CloseDocument(swModel);
//                        return isSave;
//                    }
//                }

//                //if (!string.IsNullOrEmpty(configuration))
//                //{
//                //    try
//                //    {
//                //        Console.WriteLine("Деталь из листвого метала");
//                //        string filePath;
//                //        isSave = SaveThisConfigDxf(folderToSave, configuration, fixBends ? solidWorksApp : null, swModel, out filePath, isSheetmetal);
//                //        dxfList.Add(new DxfFile
//                //        {
//                //            Configuration = configuration,
//                //            FilePath = filePath,
//                //            IdPdm = idPdm,
//                //            Version = version
//                //        });
//                //    }
//                //    catch (Exception exception)
//                //    {
//                //        throw new Exception("Failed save configurations" + exception.ToString());
//                //    }
//                //    if (closeAfterSave)
//                //    {
//                //        SolidWorksInstance.CloseDocument(swModel);
//                //    }
//                //}
//                //else
//                //{

//                string[] swModelConfNames2 = (string[])swModel.GetConfigurationNames();

//                var configurations = from name in swModelConfNames2
//                                     let config = (Configuration)swModel.GetConfigurationByName(name)
//                                     where !config.IsDerived()
//                                     select name;

//                foreach (var configName in configurations)
//                {
//                    string filePath;
//                    //  MessageBox.Show(swModel.GetTitle() + "\nsheetmetal-" + sheetmetal.ToString());
//                    isSave = SaveThisConfigDxf(/*folderToSave,*/ configName, fixBends ? solidWorksApp : null, swModel, out filePath, isSheetmetal);

//                    if (isSave)
//                    {
//                        dxfList.Add(new DxfFile
//                        {
//                            Configuration = configName,
//                            FilePath = filePath,
//                            IdPdm = idPdm,
//                            Version = version
//                        });
//                    }
//                }
//                if (closeAfterSave)
//                {
//                    SolidWorksInstance.CloseDocument(swModel);
//                }
//            }
//            // }
//            catch (Exception exception)
//            {
//                throw exception;
//            }
//           // SolidWorksInstance.CloseAllDocumentsAndExit();
//            return isSave;
//        }

//        public   bool SaveThisConfigDxf(/*string folderToSave,*/ string configuration, SldWorks swApp, IModelDoc2 swModel, out string dxfFilePath, bool isSheetmetal)
//        {

//            swModel.ShowConfiguration2(configuration);
//            swModel.EditRebuild3();

//            if (swApp != null && isSheetmetal)
//            {
//                List<Bends.SolidWorksFixPattern.PartBendInfo> list;
//                Bends.Fix(swApp, out list, true);
//            }

//            var sDxfName = DxfName(swModel.GetTitle(), configuration) + ".dxf";
//                dxfFilePath = Path.Combine(FolderToSaveDxf, sDxfName); 
//            //  dxfFilePath = Path.Combine(@"C:\DXF", sDxfName);

//            Directory.CreateDirectory(FolderToSaveDxf);

//            var dataAlignment = new double[12];

//            dataAlignment[0] = 0.0;
//            dataAlignment[1] = 0.0;
//            dataAlignment[2] = 0.0;
//            dataAlignment[3] = 1.0;
//            dataAlignment[4] = 0.0;
//            dataAlignment[5] = 0.0;
//            dataAlignment[6] = 0.0;
//            dataAlignment[7] = 1.0;
//            dataAlignment[8] = 0.0;
//            dataAlignment[9] = 0.0;
//            dataAlignment[10] = 0.0;
//            dataAlignment[11] = 1.0;
//            object varAlignment = dataAlignment;

//            var swPart = (IPartDoc)swModel;
//            int sheetmetalOptions = SheetMetalOptions(true, false, false, false, false, true, false);

//            //MessageBox.Show(sheetmetalOptions.ToString());                               

//           // if (isSheetmetal)
//       //     {
//                Console.WriteLine("ExportToDWG");
//            return swPart.ExportToDWG2(dxfFilePath, swModel.GetPathName(), isSheetmetal ? (int)swExportToDWG_e.swExportToDWG_ExportSheetMetal : (int)swExportToDWG_e.swExportToDWG_ExportSelectedFacesOrLoops, true, varAlignment, false, false, sheetmetalOptions,
//                isSheetmetal ? 0 : (int)swExportToDWG_e.swExportToDWG_ExportAnnotationViews);
//                    // old  return swPart.ExportToDWG(dxfFilePath, swModel.GetPathName(), isSheetmetal ? 1 : 2, true, varAlignment, false, false, sheetmetalOptions, isSheetmetal ? 0 : 3);
//         //   }
//            //else
//            //{
//            //    Console.WriteLine("SaveAs4 by path " + dxfFilePath);
//            //    return swModel.SaveAs4(dxfFilePath, (int)swSaveAsVersion_e.swSaveAsCurrentVersion, (int)swSaveAsOptions_e.swSaveAsOptions_Silent, 0, 0);
//            //}
//        }
//        private   string DxfName(string fileName, string config)
//        { 
//            return $"{fileName.Replace("ВНС-", "").ToLower().Replace(".sldprt", "")}-{config}";
//        }

//        private int SheetMetalOptions(bool ExportGeometry, bool IcnludeHiddenEdges, bool ExportBendLines, bool IncludeScetches, bool MergeCoplanarFaces, bool ExportLibraryFeatures, bool ExportFirmingTools)
//        {
//            return SheetMetalOptions(
//                ExportGeometry ? 1 : 0,
//                IcnludeHiddenEdges ? 1 : 0,
//                ExportBendLines ? 1 : 0,
//                IncludeScetches ? 1 : 0,
//                MergeCoplanarFaces ? 1 : 0,
//                ExportLibraryFeatures ? 1 : 0,
//                ExportFirmingTools ? 1 : 0);
//        }

//        private int SheetMetalOptions(int p0, int p1, int p2, int p3, int p4, int p5, int p6)
//        {
//            return p0 * 1 + p1 * 2 + p2 * 4 + p3 * 8 + p4 * 16 + p5 * 32 + p6 * 64;
//        }
//    }
//}
