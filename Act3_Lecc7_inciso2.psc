Algoritmo  Act3_Lecc7_inciso2
	Definir a,b,c Como Real
	
	Escribir "Luis Priego-IV-E"
	Escribir "Ingrese los tres lados del triangulo:"
	Leer a,b,c
	
	Si a=b y b=c Entonces
		Escribir "Equilatero"
	SiNo
		Si a=b o b=c o a=c Entonces
			Escribir "Isosceles"
	SiNo
		Escribir "Escaleno"
		FinSi
	FinSi
FinAlgoritmo
