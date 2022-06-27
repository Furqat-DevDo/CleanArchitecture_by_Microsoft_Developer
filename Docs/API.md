# F_DinnerAPI
-[F_DinnerAPI](#f-dinnerapi)
  -[Auth](#auth)
    -[Register](#Register)
        -[Register_Request](#Register_Request)
        -[Register_Response](#Register_Response)
    -[Login](#Login)
        -[Login_Request](#Login_Request)
        -[Login_Response](#Login_Response)
## Auth
### Register
``` js
Post {{host}}/auth/register
```
### Register_Request
    ``` json
    {
        "firstname": "string",
        "lastname": "string",
        "email": "string",
        "password": "string"
    }
    ```
### Register_Response
    ``` json
    {
        "id": "string",
        "firstname": "string",
        "lastname": "string",
        "email": "string",
        "token": "string"
    }
    ```