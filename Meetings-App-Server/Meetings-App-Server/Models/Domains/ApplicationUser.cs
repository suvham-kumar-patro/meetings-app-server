using Meetings_app_server.Models.Domain;

namespace Meetings_App_Server.Models.Domains
{
    public class ApplicationUser
    {
        // Additional properties for the user can go here
        public string FullName { get; set; }
        public List<Meeting> OrganizedMeetings { get; set; }  // Meetings organized by the user
        public List<Attendee> AttendedMeetings { get; set; }  // Meetings the user is attending
    }
}