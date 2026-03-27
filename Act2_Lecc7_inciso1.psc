Algoritmo Act2_Lecc7_inciso1
	Definir opciones Como Entero
	
	Escribir "Luis Priego-IV-E"
	Escribir "Bienvenido a MegaChamba S.A."
	Escribir "Seleccione una opcion:"
	Escribir "1. Ventas"
	Escribir "2. Atencion al cliente"
	Escribir "3. Soporte tecnico"
	Escribir "4. Recursos humanos"
	Leer opciones
	
	Si opciones = 1 Entonces
		Escribir "Te comunicamos con el area de Ventas"
	Sino
		Si opciones = 2 Entonces
			Escribir "Atencion al cliente te atendera pronto"
		Sino
			Si opciones = 3 Entonces
				Escribir "Soporte tecnico esta en camino"
			Sino
				Si opciones = 4 Entonces
					Escribir "Recursos humanos respondera tu solicitud"
				Sino
					Escribir "Opcion invalida"
				FinSi
			FinSi
		FinSi
	FinSi
FinAlgoritmo
