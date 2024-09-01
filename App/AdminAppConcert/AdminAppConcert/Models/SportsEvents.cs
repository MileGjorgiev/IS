namespace AdminAppConcert.Models
{
    public class SportsEvents
    {
        public string Name { get; set; }
        public virtual ICollection<MatchSchedules>? MatchSchedules { get; set; }
        public virtual ICollection<Ticket>? Tickets { get; set; }
    }
}
