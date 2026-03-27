Algoritmo Act2_Lecc21_inciso1
	Definir opciones Como Entero
	
	Escribir "Luis Priego-IV-E"
	Escribir "Programa de atencion telefonica"
	Escribir "Seleccione una opcion:"
	Escribir "1. Ventas"
	Escribir "2. Recepcion"
	Escribir "3. Direccion"
	Escribir "4. Compras"
	
	Leer opciones
	
	Si opciones = 1 Entonces
		Escribir "Bienvenido al departamento de Ventas"
		Escribir "Encargado: Santiago Ocaña"
		Escribir "Correo: socaña@gmail.com"
	Sino
		Si opciones = 2 Entonces
			Escribir "Bienvenido al departamento de Recepcion"
			Escribir "Encargado: Franco Peruch"
			Escribir "Correo: franco.peruch@hgmail.com"
		Sino
			Si opciones = 3 Entonces
				Escribir "Bienvenido al departamento de Direccion"
				Escribir "Encargada: Estefany Albizurez"
				Escribir "Correo: estefany.albi@gmail.com"
			Sino
				Si opciones = 4 Entonces
					Escribir "Bienvenido al departamento de Compras"
					Escribir "Encargado: Miguel Tumax"
					Escribir "Correo: miguel.tx@gmail.com"
				Sino
					Escribir "Opcion invalida"
				FinSi
			FinSi
		FinSi
	FinSi
FinAlgoritmo
