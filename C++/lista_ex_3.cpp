#include <iostream>

using namespace std;
int main (){
	
	float R,VOLUME,ALTURA, PI = 3.14159;
	
	cout<< "Digite o raio: ";
	cin >> R ;
	cout<< "Digite a Altura: ";
	cin >> ALTURA;
	
	 VOLUME = PI * R*R * ALTURA;
	 
	
	cout<< "O volume: "<< VOLUME<< endl;
	
		return 0;
}
