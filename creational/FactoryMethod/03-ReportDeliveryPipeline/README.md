# Report Delivery Pipeline

Level: Advanced

## Task

Refactor the `Start` project to use Factory Method.

The current `ReportDeliveryPipeline` coordinates a multi-step workflow and also decides how every delivery channel should be created. The workflow is stable, but channel creation varies by customer segment and operational constraints.

Use Factory Method to keep the orchestration code in a base creator while concrete delivery jobs create their own channel-specific product.

## Suggested Steps

1. Keep the report validation, rendering, audit, and delivery steps as one stable workflow.
2. Introduce an `IReportDeliveryChannel` product abstraction.
3. Create concrete channels for email, secure file transfer, and webhook delivery.
4. Create an abstract delivery job with a factory method such as `CreateDeliveryChannel`.
5. Implement concrete delivery jobs for finance, partner, and operations reports.

## Acceptance Criteria

- The delivery pipeline workflow does not contain channel-selection conditionals.
- Channel-specific headers, addresses, retries, or compliance notes live in concrete product classes.
- Adding a new delivery channel does not require editing the base workflow.
