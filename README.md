# Publish / Subscribe ASP.NET Core Application Example
Event Oriented Arch with ASP.NET and Rabbit MQ. <br>
I've followed the article in the references section to implement this example. <br>
This example was made for learning purpose. Should not be used in production environment.

## Stack
- ASP.NET Core 8;
- RabbitMQ 6.8;

## Projects
- CustomerApi: API responsible for publishing the message in the broker;
- NotificationApi and SalesApi: these are the consumers/subscribed API"s;
- Shared: Class Library Project containing the Event Class.

## How it Works?
- Customer API (publisher) creates the event and sends to the Broker exchange;
- RabbitMQ put the messages in the exchange's queues;
- Notification and Sales API's are subsribed to the queues, so they will receive the messages.

## Architecture Diagram
![image](https://github.com/user-attachments/assets/95a838e8-209e-4ef5-8f6c-f820788e48f2)

## References
- Article: https://www.luisdev.com.br/2023/01/01/implementando-publish-subscribe-com-asp-net-core-rabbitmq-e-docker/
- RabbitMQ: https://www.rabbitmq.com/

