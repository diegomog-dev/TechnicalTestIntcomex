# Prueba Tecnica Intcomex

_Prueba técnica para la compañia Intcomex para el cargo de Software Development, realizada en lenguaje C# .Net8._
_Api donde es posible consultar los productos asociados a las categorias o subcategorias que se encuentran almacenados en una base de datos con el motor MySql._

## Consultar los productos
_Las consultas se realizan directamente al EndPoint enviando tres parametros previamente establecidos:_

EndPoint
/api/Product/GetSearchProducts?parameter=${parameter}&count=${count}&numberPage=${numberPage}

parameter: _nombre de la categoria o subcategoria a consultar._
count: _número de registros a visualizar._
numberPage: _número de la página a consultar._

## Construido con 🛠️
* [C# .Net 8]

## Autor ✒️

* **Diego Armando Mogollón** - *Trabajo Inicial* - [diegomog-dev](https://github.com/diegomog-dev)
