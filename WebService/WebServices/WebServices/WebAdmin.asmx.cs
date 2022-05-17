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

        [WebMethod(Description ="Returns all available information regarding all movies")]
        public List<string> GetAllMoviesDetails()
        {
            throw new NotImplementedException();
        }

        [WebMethod(Description ="Makes an insertion into the database for a movie and all its details")]
        public bool AddMovie(List<string> details)
        {
            throw new NotImplementedException();
        }

        [WebMethod(Description ="Modifies the details of a movie")]
        public bool UpdateMovie(List<string> details, int movieId)
        {
            throw new NotImplementedException();
        }

        [WebMethod(Description ="Deletes a single movie entry from the database")]
        public bool DeleteMovie(int movieId)
        {
            throw new NotImplementedException();
        }

        [WebMethod(Description ="Returns all shifts of the employees as well as their names")]
        public List<string> GetAllWorkShifts(int cinemaId)
        {
            throw new NotImplementedException();
        }

        [WebMethod(Description ="Makes an entry in the database for a workshift of an already existing employee")]
        public bool AddWorkShift(List<string> details)
        {
            throw new NotImplementedException();
        }

        [WebMethod(Description ="Applies changes to the schedule held by an employee")]
        public bool UpdateWorkShift(List<string> details, int workShiftId)
        {
            throw new NotImplementedException();
        }

        [WebMethod(Description ="Deletes the workshift of an employee")]
        public bool DeleteWorkShift(int workShiftId)
        {
            throw new NotImplementedException();
        }

        [WebMethod(Description ="Gets the entire schedule of a said cinema")]
        public List<string> GetAllSchedulesByCinema(int cinemaId)
        {
            throw new NotImplementedException();
        }

        [WebMethod(Description ="Applies modifications to the schedule of a certain cinema")]
        public bool UpdateSchedules(List<string> details, int scheduleId)
        {
            throw new NotImplementedException();
        }
    }
}
