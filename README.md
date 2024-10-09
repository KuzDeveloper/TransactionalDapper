# Transactional Dapper Project
This is a short .Net Core solution with .Net 8 backend to show how to use Dapper in transactional way.

The point of this project is only to show how to use Dapper with multiple different tables in a transactional way, where if one operation fails, the others will also not be committed.
The code itself is made to be easily understandable, but far from being production-ready! The webapi client is a plain simple api that injects the service, the providers and other classes, but its controller is a basic one without any authentication or authorization. You can still use the generated swagger page to test the code and any additional changes you want to experiment with.



Solution hiearchy:

Clients:

- Simple .Net Core webapi with as minimal functionalities as possible as the main focus is on the Dapper layer. Still, the webapi is the orchestrator, this is why the dependency injection is here.

Core:

- Business: This is a .Net 8 class library. It is responsible to:

a. create the logical layer called "Services" that collect and transform data and do all the business operations. The BaseService has the transactional Func usage (more on that later).

b. create the "Providers" that only retrieve data from the DataAccess layer, but currently they do not do any mappings or such as that is not the focus here.

- DataAccess: This is a .Net 8 class library. It is responsible to:
a. have the .mdf database file (for simplicity, but you can change it to use cloud db or whatever you need).
b. create the db contexts to have functionalities over tables and to receive the connection and transaction instances from the calling layer.
c. have the factory for creating db connections. Currently only SQL connection is implemented to not overcomplicate the project.



TransactionalFunction:

This async method receives a Func that expects an IDbConnection and an IDbTransaction and returns a nullable T instance. The connection and transaction are created by the injected factory and the transaction is only committed if the operation ran successfully. For simplicity, there is no exception handling added here!