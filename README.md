# Moulding Technology Process Audit

Small demo project modelling moulding cards and the process audit of manufacturing plastic bricks.

## Instructions
Clone project (https://github.com/jenshenrik/moulding) and navigate to the root folder. Start the application by running `dotnet run --project API/API.csproj` or navigate to `API/` and simply run `dotnet run`.
### Usage
The above command will start the application on a local development server - check the console for which port it's running on.

Open a browser and navigate to `localhost:\<port\>/swagger` to test out the test out the endpoints through Swagger, or make HTTP requests directly against `localhost:\<port\>` using the following endpoints:

- `GET mouldcards/` - returns a list of mould cards. Useful for grabbing IDs for use with the other endpoints.
- `GET mouldcards/:id` - returns a specific mould card.
- `POST mouldcards/:id/audit` perform an audit of the specified mould card. Returns a list of alerts raised by audit, if any.

The first endpoint should return three mould cards - two which fails on different properties and one which does not fail.

### RESTful API specification
A more fully fleshed out API specfication would look something like this
- `POST mouldcards/` - create new mould card.
- `PUT mouldcards/:id` - update specified mouldcard.
- `DELETE mouldcards/:id` - delete specified mould card.
- `GET audits/` - get a list of all audits.
- `GET audits/:id` - get a specific audit.
- `GET alerts/mouldcard/:mouldCardId` - get alerts for specified mould card. Alternatively use audit instead of mould card.

## Design overview
Pretty straight forward layered architecture:

- `API` is a .NET web api project and is responsible for exposing a RESTful API for the application.
- `Application` holds business logic, specifically the audit process.
- `Domain` holds rich domain models and their internal logic.
- `Infrastructure` contains persistance logic and mocked client to communicate with moulding machines.

### Design considerations
#### Task reminders
When creating a mould card include operator ID and a time-to-audit properties. The creating service can then schedule a notification with a scheduling/notification service at a later time (time of creation + time-to-audit).'

#### Design alternatives
The domain seems like a prime candidate for microservices. In that case consider Hexagonal architecture, CQRS, and Event Sourcing.