# MathApplication
a simple MVC structure for math application 

Singleton, Scoped and Transient difference 

Transient objects are always different; a new instance is provided to every controller and every service.

Scoped objects are the same within a request, but different across different requests.

Singleton objects are the same for every object and every request.

![image](https://user-images.githubusercontent.com/55627267/184221965-38b45f59-0244-4e77-b05e-af89e8309845.png)
1st API call 
Scoped -had 2 instance created but only excute only once .
Singleton -had 2 instance created but only excute only once .
Transient- has 3 instance and all instance are excuted 

![image](https://user-images.githubusercontent.com/55627267/184222191-d0e765e8-041b-425e-b50e-6673a01244d4.png)
2nd API call
Scoped -had 2 instance created but only excute only once .
Singleton -will not excute since once created  objects are the same for every object and every request  .
Transient- has 3 instance and all instance are excuted .
