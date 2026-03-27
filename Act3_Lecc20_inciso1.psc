Algoritmo Act3_Lecc20_inciso1
	Definir dia Como Entero
	
	Escribir "Luis Priego-IV-E"
	Escribir "Ingrese un numero del 1 al 7:"
	Leer dia
	
	Si dia = 6 o dia = 7 Entonces
		Escribir "Fin de semana"
	SiNo
		Si dia >= 1 y dia <= 5 Entonces
			Escribir "Entre semana"
	SiNo
		Escribir "Numero invalido"
		FinSi
	FinSi
FinAlgoritmo
