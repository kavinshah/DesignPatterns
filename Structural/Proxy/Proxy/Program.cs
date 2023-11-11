// See https://aka.ms/new-console-template for more information
using Proxy;

INest secureNest = new SecureNestProxy(new RealNest());
secureNest.Access("Kavin");

secureNest.Access("TRex");
