//GET THE PATH TO FILE
//Wuindows Apps
//read base data
            tpiData_fullXmlFileName = Application.StartupPath;
            int index;
            index = tpiData_fullXmlFileName.IndexOf("bin");
            if (index > 0)
                tpiData_fullXmlFileName = tpiData_fullXmlFileName.Remove(index, 9);

            tpiData_fullXmlFileName = tpiData_fullXmlFileName + ConfigurationManager.AppSettings.Get("UploadTpiXmlData");

            if (System.IO.File.Exists(tpiData_fullXmlFileName))
            {
                string xmlString = System.IO.File.ReadAllText(tpiData_fullXmlFileName);
                textDataToUpload.Text = xmlString;
                button1.Focus();
            }
            else
            {
                textDataToUpload.Text = "No xml file found, please paste here XML as string data to Tpi Upload.";
            }
//In Console 
 // read JSON directly from a file
                var ser = new Newtonsoft.Json.JsonSerializer();
                var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                int index = path.IndexOf("bin");
                if (index > 0)
                    path = path.Remove(index);

                var filenamelocation = Path.Combine(path, @"Samples\\UploadTpi_request.json");
                using (StreamReader file = File.OpenText(filenamelocation))
                {
                    using (JsonTextReader reader = new JsonTextReader(file))
                    {
                        request = ser.Deserialize<_OriginationService.Models.LoanApplicationModel>(reader);
                        var response = uploadTpiClient.LoadApplicationData(request);
                        Console.WriteLine(JsonConvert.SerializeObject(response));
                    }

                }
//In web
Use this code:

HttpContext.Current.Server.MapPath("~")
Detailed Reference:

Server.MapPath specifies the relative or virtual path to map to a physical directory.

Server.MapPath(".") returns the current physical directory of the file (e.g. aspx) being executed
Server.MapPath("..") returns the parent directory
Server.MapPath("~") returns the physical path to the root of the application
Server.MapPath("/") returns the physical path to the root of the domain name (is not necessarily the same as the root of the application)
