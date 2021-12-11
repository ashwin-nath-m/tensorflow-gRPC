# TensorFlow Serving MNIST Deep C# client

This is example of C# clients for TensorFlow Serving gRPC service.

## How to start web application
- Run TensorFlow Serving
- Open .NET solution. 
- Update appsetting.json with TensorFlow Serving address:
```sh
"TfServer": {
        "ServerUrl": "192.168.1.38:9000"
    }
```
- Start web application with IIS express
- Test prediction

