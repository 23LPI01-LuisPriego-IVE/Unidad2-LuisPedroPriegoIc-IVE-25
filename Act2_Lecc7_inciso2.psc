Algoritmo  Act2_Lecc7_inciso2
	Definir nota Como Entero
	
	Escribir "Luis Priego-IV-E"
	Escribir "Ingrese su calificacion:"
	Leer nota
	
	Si nota <= 69 Entonces
		Escribir "Deficiente"
	Sino
		Si nota <= 79 Entonces
			Escribir "Regular"
		Sino
			Si nota <= 89 Entonces
				Escribir "Bien"
			Sino
				Si nota < 100 Entonces
					Escribir "Muy bien"
				Sino
					Escribir "Excelente"
				FinSi
			FinSi
		FinSi
	FinSi
FinAlgoritmo

