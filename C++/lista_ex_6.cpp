#include <iostream>

using namespace std;

int main()
{                   //Fa�a um programa que apresente o total da soma obtido dos cem primeiros n�meros inteiros. (1+2+3+4+......+100) 

	int i, s=0;
	
	for (i=1;i<=100;i++)
	{
	s= s+i;
	}
	cout<<"o total: "<<s;
	
	
	
	
	return 0;
}
