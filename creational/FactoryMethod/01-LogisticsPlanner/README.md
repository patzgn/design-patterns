# Logistics Planner

Level: Beginner

## Task

Refactor the `Start` project to use Factory Method.

The current code calculates delivery plans by using a `switch` expression inside `DeliveryPlanner`. Every time a new delivery type appears, the planner must be edited.

Move transport creation behind a factory method so the planning workflow can stay unchanged while concrete planners decide which transport to create.

## Suggested Steps

1. Introduce an `ITransport` product interface.
2. Create concrete products such as `Truck`, `Ship`, and `Drone`.
3. Create an abstract `DeliveryPlanner` creator with a factory method such as `CreateTransport`.
4. Move the shared planning algorithm into the base creator.
5. Add concrete creators such as `RoadDeliveryPlanner`, `SeaDeliveryPlanner`, and `AirDeliveryPlanner`.

## Acceptance Criteria

- `DeliveryPlanner` no longer contains a `switch` for transport creation.
- Each transport type has its own concrete product class.
- Adding a new transport type does not require editing the shared planning workflow.
