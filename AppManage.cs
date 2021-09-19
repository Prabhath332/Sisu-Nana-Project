using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Loader;
using System.Threading.Tasks;
using web_project.Models;

namespace web_project
{
    public class AppManage
    {

        public static int LoggedInType = 0;
        public static int LoggedInUserId = 0;
        public static string ErrorMsg = "";
        
        
        public static string containerName = "puppyimages1236777";
        public static string blobUrl = "https://webdiag327.blob.core.windows.net/puppyimages1236777/";
       public static string  blobstring = "DefaultEndpointsProtocol=https;AccountName=webdiag327;AccountKey=bLk1t1hJw4CWpwK3GtXe6yK3m9oWPnthIh4qRvI8psX0Dr8SAZU6IUFXTw6o50+Z/Hvgr//9vygRDxft6ahfzQ==;EndpointSuffix=core.windows.net";// Environment.GetEnvironmentVariable("STORAGE_STRING");




    }



}
