using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServices
{
    /// <summary>
    /// Summary description for WebAdmin
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebAdmin : System.Web.Services.WebService
    {

        [WebMethod]
        public List<string> GetAllMoviesDetails()
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public bool AddMovie(List<string> details)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public bool UpdateMovie(List<string> details, int movieId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteMovie(int movieId)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public List<string> GetAllWorkShifts(int cinemaId)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public bool AddWorkShift(List<string> details)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public bool UpdateWorkShift(List<string> details, int workShiftId)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public bool DeleteWorkShift(int workShiftId)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public List<string> GetAllSchedulesByCinema(int cinemaId)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public bool UpdateSchedules(List<string> details, int scheduleId)
        {
            throw new NotImplementedException();
        }
    }
}
