namespace NetSamples.Delegates;

delegate void PrintMessage();

delegate decimal CalculatePrice(int distance);

delegate T SomeGenericMethod<T,TY>(TY val); // u can use limitation

delegate double MathOperation(double x, double y);