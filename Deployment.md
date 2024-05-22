# Deployment

The Backend of the Car-Rental application is implemented as an **ASP.NET Core Web API** providing the necessary CRUD
operations and bridging the gap to the Postgresql Database used for persisting the data.
**Entity Framework Core** is used for the ORM and the database migrations.
The Frontend is implemented as a **React** (**Next.js**) web application that consumes the Backend API..