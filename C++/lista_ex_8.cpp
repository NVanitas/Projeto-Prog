#include <iostream>

using namespace std;

int main()
{
    int i,n;
    float res,maior,media=0,s=0;

    for (i=1;i<=15;i++)
    {
        cout << "Digite um valor: \n";
        cin >> n;

        s=s+n;
        media=s/i;

        if (i==1)
        {
            maior=maior+n;
            
        }
        if (n>=maior)
        {
            maior=n;
        }
        
       
    }
        res=media-maior;
        cout << "A media: "<<media<<endl;
        cout << "Maior: "<<maior<<endl;
        cout << "A diferenca entre a media e o maior valor e de: "<<res<<endl;



    return 0;
}