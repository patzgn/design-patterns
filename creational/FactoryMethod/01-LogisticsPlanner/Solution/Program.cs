using LogisticsPlanner.Solution.Planners;

var droneDelivery = new AirDeliveryPlanner();
Console.WriteLine(droneDelivery.PlanDelivery("Order-1042"));

var shipDelivery = new SeaDeliveryPlanner();
Console.WriteLine(shipDelivery.PlanDelivery("Order-1042"));

var truckDelivery = new RoadDeliveryPlanner();
Console.WriteLine(truckDelivery.PlanDelivery("Order-1042"));
