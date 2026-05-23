using ReportDeliveryPipeline.Solution.DeliveryChannels;

namespace ReportDeliveryPipeline.Solution.DeliveryPipelines;

public abstract class ReportDeliveryPipeline
{
    public string Deliver(ReportRequest request)
    {
        Validate(request);
        var renderedReport = Render(request);

        var channel = CreateDeliveryChannel();

        var deliveryResult = channel.Deliver(renderedReport);
        var auditEntry = $"Audit: report {request.Id} delivered to {request.Audience}.";

        return $"{deliveryResult}{Environment.NewLine}{auditEntry}";
    }

    protected abstract IReportDeliveryChannel CreateDeliveryChannel();

    private static void Validate(ReportRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Body))
        {
            throw new ArgumentException("Report body cannot be empty.");
        }
    }

    private static RenderedReport Render(ReportRequest request) =>
        new(request.Id, $"# {request.Title}{Environment.NewLine}{request.Body}");
}
