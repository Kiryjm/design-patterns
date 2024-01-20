var basic = FactoryCreator.GetFactory(false);
var basicCircle = basic.Create(Shape.Circle);
basicCircle.Draw();

var roundedSquare = FactoryCreator.GetFactory(true).Create(Shape.Square);
roundedSquare.Draw();