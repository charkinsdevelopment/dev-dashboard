using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevDashboardProject.Models
{
    public class DashboardViewModel
    {
        public DashboardViewModel()
        {
            this.TotalCompletedTickets = 50;
            this.LeaderBoards = new List<LeaderBoardModel>();
            this.LeaderBoards.Add(new LeaderBoardModel() { Name = "Cory", TicketsCompleted = 10 });
            this.LeaderBoards.Add(new LeaderBoardModel() { Name = "Chris", TicketsCompleted = 10 });
            this.LeaderBoards.Add(new LeaderBoardModel() { Name = "Scott", TicketsCompleted = 10 });
            this.LeaderBoards.Add(new LeaderBoardModel() { Name = "Melissa", TicketsCompleted = 10 });
            this.LeaderBoards.Add(new LeaderBoardModel() { Name = "Cody", TicketsCompleted = 10 });
            this.LeaderBoards.Add(new LeaderBoardModel() { Name = "Daniel", TicketsCompleted = 10 });
            this.Errors = 3;
            this.CompletedHeadlines = 12;
            this.RemainingHeadlines = 7;
            this.AverageTimeToCompleted = new TimeToCompleteModel();
            this.AverageTimeToCompleted.Span = 3;
            this.AverageTimeToCompleted.Unit = "Days";
            this.LastWeekCompletedTickets = 45;
            if(this.TotalCompletedTickets > this.LastWeekCompletedTickets)
            {
                this.TicketCompletedTrend = "Up from last week's " + LastWeekCompletedTickets;
            } else if (this.TotalCompletedTickets == this.LastWeekCompletedTickets)
            {
                this.TicketCompletedTrend = "Same as last week's " + LastWeekCompletedTickets;
            } else
            {
                this.TicketCompletedTrend = "Down from last week's " + LastWeekCompletedTickets;
            }

            this.CompletedHeadlineBreakdown = new List<HeadlineItemsModel>();
            this.CompletedHeadlineBreakdown.Add(new HeadlineItemsModel() { ProjectName = "Websites", TicketNumber = 6 });
            this.CompletedHeadlineBreakdown.Add(new HeadlineItemsModel() { ProjectName = "Control Panel", TicketNumber = 6 });
            this.RemainingHeadlineBreakdown = new List<HeadlineItemsModel>();
            this.RemainingHeadlineBreakdown.Add(new HeadlineItemsModel() { ProjectName = "Websites", TicketNumber = 4 });
            this.RemainingHeadlineBreakdown.Add(new HeadlineItemsModel() { ProjectName = "Control Panel", TicketNumber = 3 });
        }
        public int LastWeekCompletedTickets { get; set; }
        public int TotalCompletedTickets { get; set; }
        public string TicketCompletedTrend { get; set; }
        public List<LeaderBoardModel> LeaderBoards { get; set; }
        public int Errors { get; set; }
        public int CompletedHeadlines { get; set; }
        public List<HeadlineItemsModel> CompletedHeadlineBreakdown { get; set; }
        public List<HeadlineItemsModel> RemainingHeadlineBreakdown { get; set; }
        public int RemainingHeadlines { get; set; }
        public TimeToCompleteModel AverageTimeToCompleted { get; set; }
    }

    public class TimeToCompleteModel
    {
        public int Span { get; set; }
        public string Unit { get; set; }
    }

    public class HeadlineItemsModel
    {
        public string ProjectName { get; set; }
        public int TicketNumber { get; set; }
    }
}