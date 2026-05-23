namespace ReportDeliveryPipeline.Solution.DeliveryChannels;

public interface IReportDeliveryChannel
{
    string Deliver(RenderedReport report);
}
