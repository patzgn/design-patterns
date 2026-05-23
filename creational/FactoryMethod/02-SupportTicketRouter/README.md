# Support Ticket Router

Level: Intermediate

## Task

Refactor the `Start` project to use Factory Method.

The current `TicketRouter` contains both the routing workflow and the creation rules for concrete ticket handlers. This makes the router harder to extend when new departments or escalation policies appear.

Extract the handler creation decision into factory methods implemented by concrete routing workflows.

## Suggested Steps

1. Keep `ITicketHandler` as the product abstraction.
2. Create an abstract creator that contains the common ticket routing workflow.
3. Add a factory method that returns an `ITicketHandler`.
4. Implement concrete creators for billing, technical, and security tickets.
5. Make the client choose the correct creator before running the workflow.

## Acceptance Criteria

- The shared routing workflow does not instantiate concrete handlers directly.
- Each route type has a dedicated creator class.
- Handler-specific behavior stays inside handler classes.
