#include <iostream>

using namespace std;

int main()
{
	
	int i, maior, n, s=0;
	
		cout << "Digite um numero: ";
		cin >> n;	
		s= s + n;
		
	for(i=0;i<4;i++)
	{
		cout << "Digite um numero: ";
		cin >> n;
		
		if(n>=s)
		{
			maior=n;
		}
			
	}
	
	cout << "maior: "<<maior;
	
	
	return 0;
}
