using ReportDeliveryPipeline.Solution;
using ReportDeliveryPipeline.Solution.DeliveryPipelines;

var financeReportRequest =
    new ReportRequest("R-7001", "finance", "Quarterly revenue", "Revenue grew by 8 percent.");
var financeReportDeliveryPipeline = new FinanceReportDeliveryPipeline();
Console.WriteLine(financeReportDeliveryPipeline.Deliver(financeReportRequest));
Console.WriteLine();

var partnerReportRequest =
    new ReportRequest("R-7002", "partner", "Partner inventory", "Inventory sync completed.");
var partnerReportDeliveryPipeline = new PartnerReportDeliveryPipeline();
Console.WriteLine(partnerReportDeliveryPipeline.Deliver(partnerReportRequest));
Console.WriteLine();

var operationsReportRequest =
    new ReportRequest("R-7003", "operations", "Nightly incident summary", "No critical incidents.");
var operationsReportDeliveryPipeline = new OperationsReportDeliveryPipeline();
Console.WriteLine(operationsReportDeliveryPipeline.Deliver(operationsReportRequest));
Console.WriteLine();
