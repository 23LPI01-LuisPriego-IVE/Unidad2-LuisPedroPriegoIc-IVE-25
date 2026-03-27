	//Primavera empieza aprox 21 de marzo
	//Verano 21 de junio
	//Otoño 21 de septiembre
	//Invierno 21 de diciembre
	
Algoritmo  Act3_Lecc7_inciso1
	Definir dia, mes Como Entero
	
	Escribir "Luis Priego-IV-E"
	Escribir "Consulta de estacion del año"
	Escribir "Ingrese el dia:"
	Leer dia
	
	Escribir "Ingrese el mes (1-12):"
	Leer mes
	
	Si mes < 1 o mes > 12 Entonces
		Escribir "Fecha invalida"
	Sino
		Si dia < 1 Entonces
			Escribir "Fecha invalida"
		Sino
			Si mes = 2 y dia > 29 Entonces
				Escribir "Fecha invalida"
			Sino
				Si (mes = 4 o mes = 6 o mes = 9 o mes = 11) y dia > 30 Entonces
					Escribir "Fecha invalida"
				Sino
					Si (mes=12 y dia>=21) o (mes=1) o (mes=2) o (mes=3 y dia<21) Entonces
						Escribir "Invierno"
					Sino
						Si (mes=3 y dia>=21) o (mes=4) o (mes=5) o (mes=6 y dia<21) Entonces
							Escribir "Primavera"
						Sino
							Si (mes=6 y dia>=21) o (mes=7) o (mes=8) o (mes=9 y dia<21) Entonces
								Escribir "Verano"
							Sino
								Escribir "Otoño"
							FinSi
						FinSi
					FinSi
				FinSi
			FinSi
		FinSi
	FinSi
FinAlgoritmo
