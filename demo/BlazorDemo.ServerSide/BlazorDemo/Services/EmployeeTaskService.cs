using System;
using System.Collections.Generic;
using System.Linq;
using BlazorDemo.Data.EmployeeTasks;
using DevExpress.Data.Utils;

namespace BlazorDemo.Services {
    public class EmployeeTaskService {

        /*BeginHide*/
        List<EmployeeTask> LastGeneratedTasks { get; set; }
        DateOnly LastGeneratedDate { get; set; } = DateOnly.MinValue;
        /*EndHide*/

        public List<EmployeeTask> GetEmployees() {
            // Return your data here
            /*BeginHide*/
            if(LastGeneratedTasks == null || LastGeneratedDate < DateOnly.FromDateTime(DateTime.Today)) {
                var generator = new EmployeeTaskGenerator();
                LastGeneratedTasks = generator.CreateTasks(100);
                LastGeneratedDate = DateOnly.FromDateTime(DateTime.Today);
            }
            return LastGeneratedTasks.ToList();
            /*EndHide*/
        }

        /*BeginHide*/
        class EmployeeTaskGenerator {

            static readonly NonCryptographicRandom Random = NonCryptographicRandom.Default;

            int employeePosition;
            int subtaskPosition;

            public List<EmployeeTask> CreateTasks(int count) {
                employeePosition = 0;
                subtaskPosition = 0;
                var startDate = DateTime.Today.AddDays(-200);
                var dueDate = DateTime.Today.AddDays(200);
                List<EmployeeTask> employeeTasks = new List<EmployeeTask>();

                int rootCount = RootTaskNames.Count();
                int id = 1;
                int subtaskCount = count - rootCount;
                for(int i = 0; i < rootCount; i++) {
                    var task = new EmployeeTask();
                    int complete = 0;
                    employeeTasks.Add(task);
                    task.ID = id++;
                    task.ParentID = 0;
                    task.Employee = GetEmployee();
                    task.Name = RootTaskNames[i];
                    CalcDate(task, startDate, dueDate);
                    var tasks = GenerateSubTasks(task, CalcSubtaskCount(subtaskCount, rootCount - i), ref complete);
                    id += tasks.Count;
                    subtaskCount -= tasks.Count;
                    employeeTasks.AddRange(tasks);
                    if(tasks.Count != 0)
                        task.Status = complete / tasks.Count;
                    else
                        CalcStatus(task);
                }

                return employeeTasks;
            }

            string GetEmployee() {
                if(EmployeeNames.Length == employeePosition)
                    employeePosition = 0;
                return EmployeeNames[employeePosition++];
            }

            int CalcSubtaskCount(int subtaskCount, int rootCount) {int value = subtaskCount / rootCount;
                if(value + 10 < 1)
                    return 0;
                int minValue = 1;
                if(value > 10)
                    minValue = value - 10;
                return Random.Next(minValue, value + 10);
            }

            List<EmployeeTask> GenerateSubTasks(EmployeeTask parent, int subtaskCount, ref int complete) {
                List<EmployeeTask> tasks = new List<EmployeeTask>();
                int id = parent.ID + 1;
                for(int i = 0; i < subtaskCount; i++) {
                    var task = new EmployeeTask();
                    tasks.Add(task);
                    int taskID = GetSubtaskPosition();
                    task.Name = SubtaskNames[taskID];
                    task.Employee = GetEmployee();
                    task.ID = id++;
                    task.ParentID = parent.ID;
                    task.Priority = GetPriority();
                    CalcDate(task, parent.StartDate, parent.DueDate, i == 0, i + 1 == subtaskCount);
                    CalcStatus(task);
                    complete += task.Status;
                }

                return tasks;
            }

            void CalcDate(EmployeeTask task, DateTime startDate, DateTime dueDate, bool isFirst = false, bool isLast = false) {
                var delta = dueDate.Subtract(startDate);
                var stDT = isFirst ? startDate : GetDate(startDate, 1, delta.Days);
                var deDT = isLast ? dueDate : GetDate(dueDate, -1, delta.Days);
                while(stDT.Equals(deDT))
                    deDT = GetDate(dueDate, -1, delta.Days);
                if(stDT > deDT) {
                    task.StartDate = deDT;
                    task.DueDate = stDT;
                } else {
                    task.StartDate = stDT;
                    task.DueDate = deDT;
                }
            }

            int GetSubtaskPosition() {
                if(subtaskPosition == SubtaskNames.Length)
                    subtaskPosition = 0;
                return subtaskPosition++;
            }

            int GetPriority() {
                int value = Random.Next(-100, 100);
                if(value < 0)
                    return -1;
                if(value < 60)
                    return 0;
                return 1;
            }

            void CalcStatus(EmployeeTask task) {
                int status = 0;
                if(task.StartDate > DateTime.Today)
                    status = Random.Next(0, 200) / 9;
                else {
                    status = Random.Next(800, 1000) / 9;
                    if(task.DueDate > DateTime.Today) {
                        int dif = task.DueDate.Subtract(task.StartDate).Days;
                        int difNow = task.DueDate.Subtract(DateTime.Today).Days;
                        status = (int) (status * (float) difNow / dif);
                    } else {
                        if(status < 100 && Random.NextDouble() > 0.2) {
                            int lateDays = DateTime.Today.Subtract(task.DueDate).Days;
                            task.DueDate = task.DueDate.AddDays(lateDays + Random.Next(15));
                        }
                    }
                }

                if(status > 100)
                    status = 100;
                task.Status = status;
            }

            DateTime GetDate(DateTime time, int sign, int delta) {
                return time.AddDays(sign * Random.Next(0, delta));
            }

            static string[] RootTaskNames = new[] {
                "Simplify & Clarify Product Messaging",
                "Create Action Plan To Improve Customer Engagement",
                "Increase Average Subscription Price ",
                "Reduce Churn to Less Than 1% Monthly",
                "Finalize The Content Strategy",
                "Grow Subscriber Base by 5% Per Week",
                "Increase The CTR% To Above Industry Average 3.5%",
                "Close The Final Budget",
                "Achieve Record Metrics In All Areas",
                "Begin Content Review",
                "Produce Online Survey",
                "Improve Our Content And Its Distribution",
                "Update Old Content",
                "Map And Analyze Marketing Channels",
                "Research And Improve Customer Satisfaction",
                "Present An Action Plan For Next Quarter",
                "Achieve Record Revenues While Increasing Profitability",
                "Hit Quarterly Revenue Of Over $1000000",
                "Start Sales In 2 New Countries",
                "Increase Gross Profit Margin % From 63% To 54%",
                "Reach Monthly Recurring Revenue ($ MRR) Of $250000",
                "Increase Recurring Revenues",
                "Achieve Trial To % Paid Ratio of Over 50%",
                "Implement New Product Planning Process",
                "Redesign And Launch Our New Landing Page",
                "Design New Version Of Our Site Structure, Navigation And All Pages",
                "Support Marketing And Sales With Design Deliverables",
                "Promote Our Design Team As The Best Place To Work",
                "Improve Annual Budgeting And Business Planning",
                "Receive Business Line Budget Proposals Before",
                "Finish Raising New Capital For Growth Needs",
                "Improve Internal Document Management",
                "Choose And Launch New Document Sharing Platform",
                "Increase End-User Satisfaction Rating From 4.0 To 4.5",
                "Implement A Better System For Tracking Incoming Requests",
                "Collect More Accurate Sales Leads Data",
                "Train Sales Staff"
            };

            static string[] SubtaskNames = new[] {
                "Prepare Financial Reports",
                "Prepare Marketing Plan",
                "Update Personnel Files",
                "Review Health Insurance Options ",
                "Choose Between PPO And HMO Health Plan",
                "Update Google Adwords Strategy",
                "Create New Brochure Design",
                "Obtain Price Quote For New Brochure",
                "Brochure Design Review",
                "Review Website Re-Design Strategy",
                "Rollout New Website",
                "Update Sales/Marketing Strategy",
                "Update Sales/Revenue Report",
                "Direct Vs Online Sales Comparison Report",
                "Review Sales Report and Approve Modifications",
                "Update R&D Strategy",
                "Discuss Updated R&D Strategy",
                "Update QA Strategy",
                "Schedule Training Events",
                "Approve The Hiring Of John Jeffers",
                "Update Non-Compete Agreements",
                "Update Employee Records With New NDA",
                "Sign Updated NDAs",
                "Submit Questions Regarding New NDA",
                "Submit Signed NDA",
                "Update Revenue Projections",
                "Review Revenue Projections",
                "Comment On Revenue Projections",
                "Provide New Health Insurance Docs",
                "Review Changes to Health Insurance Coverage",
                "Scan Health Insurance Forms",
                "Sign Health Insurance Forms",
                "Follow Up with West Coast Stores",
                "Follow Up with East Coast Stores",
                "Send Email to Customers About Recall",
                "Submit Refund Report For 2017 Recall",
                "Obtain Final Approval for Refunds",
                "Prepare Product Recall Report",
                "Review Product Recall Report with Engineering Team",
                "Create Training Course for New TVs",
                "Review Training Course for Omissions",
                "Review Overtime Report",
                "Submit Overtime Request Forms",
                "Overtime Approval Guidelines",
                "Refund Request Template",
                "Recall Rebate Form",
                "Create Report on Customer Feedback",
                "Review Customer Feedback Report",
                "Customer Feedback Report Analysis",
                "Prepare Shipping Cost Analysis Report",
                "Provide Feedback on Shippers",
                "Select Preferred Shipper",
                "Complete Shipper Selection Form",
                "Upgrade Server Hardware",
                "Upgrade Personal Computers",
                "Approve Personal Computer Upgrade Plan",
                "Decide On Mobile Devices Used In the Field",
                "Upgrade Apps to WPF or Stay With WinForms",
                "Estimate Time Required to Touch-Enable Apps",
                "Report on Transition to Touch-Based Apps",
                "Try New Touch-Enabled WinForms Apps",
                "Rollout New Touch-Enabled WinForms Apps",
                "Site Up-Time Report",
                "Review Site Up-Time Report",
                "Review Online Sales Report",
                "Determine New Online Marketing Strategy",
                "New Online Marketing Strategy",
                "Approve New Online Marketing Strategy",
                "Submit New Website Design",
                "Create Icons For Website",
                "Review Psds For New Website",
                "Create New Shopping Cart",
                "Create New Product Pages",
                "Review New Product Pages",
                "Approve Website Launch",
                "Launch New Website",
                "Update Customer Shipping Profiles",
                "Create New Shipping Return Labels",
                "Get Design For Shipping Return Labels",
                "PSD Needed For Shipping Return Labels",
                "Request Bandwidth Increase From ISP",
                "Submit D&B Number To ISP For Credit Approval",
                "Contact ISP And Discuss Payment Options",
                "Prepare Year-End Support Summary Report",
                "Analyze Support Traffic",
                "Review New Training Material",
                "Distribute Training Material To Support Staff",
                "Training Material Distribution Schedule",
                "Provide New Artwork To Support Team",
                "Publish New Art On The Server",
                "Replace Old Artwork With New Artwork",
                "Ship New Brochures To Field",
                "Ship Brochures To Todd Hoffman",
                "Update Server With Service Packs",
                "Install New Database",
                "Approve Overtime For HR",
                "Review New HDMI Specification",
                "Approval On Converting To New HDMI Specification",
                "Create New Spike For Automation Server",
                "Report On Retail Sales Strategy",
                "Code Review - New Automation Server",
                "Feedback On New Training Course",
                "Send Monthly Invoices From Shippers",
                "Schedule Meeting With Sales Team",
                "Confirm Availability For Sales Meeting",
                "Reschedule Sales Team Meeting",
                "Send 2 Remotes For Giveaways",
                "Ship 2 Remotes Priority To Clark Morgan",
                "Discuss Product Giveaways With Management",
                "Follow Up Email With Recent Online Purchasers",
                "Replace Desktops On The 3rd Floor",
                "Update Database With New Leads",
                "Mail New Leads For Follow Up",
                "Send Territory Sales Breakdown",
                "Territory Sales Breakdown Report",
                "Return Merchandise Report",
                "Report On The State Of Engineering Dept",
                "Staff Productivity Report",
                "Review HR Budget Company Wide",
                "Sales Dept Budget Request Report",
                "Support Dept Budget Report",
                "IT Dept Budget Request Report",
                "Engineering Dept Budget Request Report",
                "1Q Travel Spend Report",
                "Approve Benefits Upgrade Package",
                "Final Budget Review",
                "State Of Operations Report",
                "Online Sales Report",
                "Reprint All Shipping Labels",
                "Shipping Label Artwork",
                "Specs For New Shipping Label",
                "Move Packaging Materials To New Warehouse",
                "Move Inventory To New Warehouse",
                "Take Forklift To Service Center",
                "Approve Rental Of Forklift",
                "Give Final Approval To Rent Forklift",
                "Approve Overtime Pay",
                "Approve Vacation Request",
                "Approve Salary Increase Request",
                "Review Complaint Reports",
                "Review Website Complaint Reports",
                "Fix Synchronization Issues",
                "Free Up Space For New Application Set",
                "Install New Router In Dev Room",
                "Update Your Profile On Website",
                "Schedule Conf Call With Supermart",
                "Support Team Evaluation Report",
                "Create New Installer ",
                "Pickup Packages From The Warehouse",
                "Sumit Travel Expenses For Recent Trip",
                "Make Travel Arrangements For Sales Trip To San Francisco",
                "Book Flights To San Fran For Sales Trip",
                "Collect Customer Reviews For Website",
                "Submit New W4 For Updated Exemptions",
                "Get New Frequent Flier Account",
                "Review New Customer Follow Up Plan",
                "Submit Customer Follow Up Plan Feedback",
                "Review Issue Report And Provide Workarounds",
                "Contact Customers For Video Interviews",
                "Resubmit Request For Expense Reimbursement",
                "Approve Vacation Request Form",
                "Email Test Report On New Products",
                "Send Receipts For All Flights Last Month",
                "New Shipping Labels",
                "PSD Needed For Shipping Labels",
                "Online Retail Purchasers",
                "Update NDA Agreement",
                "Test New Automation App",
                "Review Training Content",
                "Classroom Size",
                "Specs For Automation App",
                "Business Cards",
                "Update Address",
                "Review Automation App",
                "Tradeshow Flight",
                "Tradeshow Marketing Message",
                "Per Diem",
                "Health Insurance Notification",
                "Lunch Potluck",
                "Review Benefits",
                "Training",
                "Submitted Reports",
                "Review Articles",
                "NDA Revision",
                "Budget Reports",
                "Sales Report By Territory",
                "Leads Generated From Atlanta",
                "Materials Needed For On-Site Event",
                "Northwest Territory Customers",
                "Retail Sales Meeting",
                "New Warehourse",
                "Purchase 2 New Remotes",
                "Walk Thru With Shipping Companies",
                "Missing Signatures",
                "Review Training Manual - First Draft",
                "Online Video Content",
                "Prepare Financial",
                "Prepare Marketing Plan",
                "Update Personnel Files",
                "Review Health Insurance Options ",
                "Choose Between PPO And HMO Health Plan",
                "Google Adwords Strategy",
                "New Brochures",
                "Brochure Designs",
                "Brochure Design Review",
                "Website Re-Design Plan",
                "Rollout Of New Website and Marketing Brochures",
                "Update Sales Strategy Documents",
                "Create Sales Report",
                "Direct Vs Online Sales Comparison Report",
                "Review Sales Report and Approve Plans",
                "Deliver R&D Plans",
                "Create R&D Plans",
                "QA Strategy Report",
                "Training Events",
                "Approve Hiring Of John Jeffers",
                "Non-Compete Agreements",
                "Update Employee Files with New NDA",
                "Sign Updated NDA",
                "Submit Questions Regarding New NDA",
                "Submit Signed NDA",
                "Update Revenue Projections",
                "Review Revenue Projections",
                "Comment On Revenue Projections",
                "Provide New Health Insurance Docs",
                "Review Changes To Health Insurance Coverage",
                "Scan Health Insurance Forms",
                "Sign Health Insurance Forms",
                "Follow Up With West Coast Stores",
                "Follow Up With East Coast Stores",
                "Send Email To Customers About Recall",
                "Submit Refund Report For 2017 Recall",
                "Give Final Approval For Refunds",
                "Prepare Product Recall Report",
                "Review Product Recall Report By Engineering Team",
                "Create Training Course For New Tvs",
                "Review Training Course For Any Omissions",
                "Review Overtime Report",
                "Submit Overtime Request Forms",
                "Overtime Approval Guidelines",
                "Refund Request Template",
                "Recall Rebate Form",
                "Create Report On Customer Feedback",
                "Review Customer Feedback Report",
                "Customer Feedback Report Analysis",
                "Prepare Shipping Cost Analysis Report",
                "Provide Feedback On Shippers",
                "Select Preferred Shipper",
                "Complete Shipper Selection Form",
                "Upgrade Server Hardware",
                "Upgrade Personal Computers",
                "Approve Personal Computer Upgrade Plan",
                "Decide On Mobile Devices To Use In The Field",
                "Upgrade Apps To Windows RT Or Stay With WinForms",
                "Estimate Time Required To Touch-Enable Apps",
                "Report On Tranistion To Touch-Based Apps",
                "Try New Touch-Enabled WinForms Apps",
                "Rollout New Touch-Enabled WinForms Apps",
                "Site Up-Time Report",
                "Review Site Up-Time Report",
                "Review Online Sales Report",
                "Determine New Online Marketing Strategy",
                "New Online Marketing Strategy",
                "Approve New Online Marketing Strategy",
                "Submit New Website Design",
                "Create Icons For Website",
                "Review Psds For New Website",
                "Create New Shopping Cart",
                "Create New Product Pages",
                "Review New Product Pages",
                "Approve Website Launch",
                "Launch New Website",
                "Update Customer Shipping Profiles",
                "Create New Shipping Return Labels",
                "Get Design For Shipping Return Labels",
                "PSD Needed For Shipping Return Labels",
                "Request Bandwidth Increase From ISP",
                "Submit D&B Number To ISP For Credit Approval",
                "Contact ISP And Discuss Payment Options",
                "Prepare Year-End Support Summary Report",
                "Analyze Support Traffic",
                "Review New Training Material",
                "Distribute Training Material To Support Staff",
                "Training Material Distribution Schedule",
                "Provide New Artwork To Support Team",
                "Publish New Art On The Server",
                "Replace Old Artwork With New Artwork",
                "Ship New Brochures To Field",
                "Ship Brochures To Todd Hoffman",
                "Update Server With Service Packs",
                "Install New Database",
                "Approve Overtime For HR",
                "Review New HDMI Specification",
                "Approval On Converting To New HDMI Specification",
                "Create New Spike For Automation Server",
                "Report On Retail Sales Strategy",
                "Code Review - New Automation Server",
                "Feedback On New Training Course",
                "Send Monthly Invoices From Shippers",
                "Schedule Meeting With Sales Team",
                "Confirm Availability For Sales Meeting",
                "Reschedule Sales Team Meeting",
                "Send 2 Remotes For Giveaways",
                "Ship 2 Remotes Priority To Clark Morgan",
                "Discuss Product Giveaways With Management",
                "Follow Up Email With Recent Online Purchasers",
                "Replace Desktops On The 3rd Floor",
                "Update Database With New Leads",
                "Mail New Leads For Follow Up",
                "Send Territory Sales Breakdown",
                "Territory Sales Breakdown Report",
                "Return Merchandise Report",
                "Report On The State Of Engineering Dept",
                "Staff Productivity Report",
                "Review HR Budget Company Wide",
                "Sales Dept Budget Request Report",
                "Support Dept Budget Report",
                "IT Dept Budget Request Report",
                "Engineering Dept Budget Request Report",
                "1Q Travel Spend Report",
                "Approve Benefits Upgrade Package",
                "Final Budget Review",
                "State Of Operations Report",
                "Online Sales Report",
                "Reprint All Shipping Labels",
                "Shipping Label Artwork",
                "Specs For New Shipping Label",
                "Move Packaging Materials To New Warehouse",
                "Move Inventory To New Warehouse",
                "Take Forklift To Service Center",
                "Approve Rental Of Forklift",
                "Give Final Approval To Rent Forklift",
                "Approve Overtime Pay",
                "Approve Vacation Request",
                "Approve Salary Increase Request",
                "Review Complaint Reports",
                "Review Website Complaint Reports",
                "Fix Synchronization Issues",
                "Free Up Space For New Application Set",
                "Install New Router In Dev Room",
                "Update Your Profile On Website",
                "Schedule Conf Call With Supermart",
                "Support Team Evaluation Report",
                "Create New Installer For Company Wide App Deployment",
                "Pickup Packages From The Warehouse",
                "Sumit Travel Expenses For Recent Trip",
                "Make Travel Arrangements For Sales Trip To San Francisco",
                "Book Flights To San Fran For Sales Trip",
                "Collect Customer Reviews For Website",
                "Submit New W4 For Updated Exemptions",
                "Get New Frequent Flier Account",
                "Review New Customer Communication Plan",
                "Prepare Customer Feedback Report ",
                "Review Customer Bug Reports/Prep Workarounds ",
                "Contact Customers For Video Interviews ",
                "Resubmit Request For Expense Reimbursement",
                "Approve Vacation Request Form",
                "Email Test Report On New Products ",
                "Send Receipts For All Flights Last Month",
                "Create New Shipping Labels",
                "PSD Needed For Shipping Labels",
                "Produce Report On Retail Purchase Patterns",
                "Update NDA Agreement"
            };

            static string[] EmployeeNames = new[] {
                "John Heart",
                "Samantha Bright",
                "Arthur Miller",
                "Robert Reagan",
                "Greta Sims",
                "Brett Wade",
                "Sandra Johnson",
                "Ed Holmes",
                "Barb Banks",
                "Kevin Carter",
                "Cindy Stanwick",
                "Sammy Hill",
                "Davey Jones",
                "Victor Norris",
                "Mary Stern",
                "Robin Cosworth",
                "Kelly Rodriguez",
                "James Anderson",
                "Antony Remmen",
                "Olivia Peyton",
                "Taylor Riley",
                "Amelia Harper",
                "Wally Hobbs",
                "Brad Jameson",
                "Karen Goodson",
                "Marcus Orbison",
                "Sandy Bright",
                "Morgan Kennedy",
                "Violet Bailey",
                "Ken Samuelson",
                "Nat Maguiree",
                "Bart Arnaz",
                "Leah Simpson",
                "Arnie Schwartz",
                "Billy Zimmer",
                "Samantha Piper",
                "Maggie Boxter",
                "Terry Bradley",
                "Gabe Jones",
                "Lucy Ball",
                "Jim Packard",
                "Hannah Brookly",
                "Harv Mudd",
                "Clark Morgan",
                "Todd Hoffman",
                "Jackie Garmin",
                "Lincoln Bartlett",
                "Brad Farkus",
                "Jenny Hobbs",
                "Dallas Lou",
                "Stu Pizaro"
            };
        }
        /*EndHide*/
    }
}
