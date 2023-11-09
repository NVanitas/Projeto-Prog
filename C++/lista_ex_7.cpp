#include <iostream>

using namespace std;

int sf(int n) 
{
  int f;
  
  if (n == 1) 
  {
    return(1);
  }
  
  if (n == 2) 
  {
    return(1);
  }
  
  f = sf(n-1) + sf(n-2);

  
  return(f);
}

int main() {
  int n=15,i;
  
  
  for (i = 1; i <= n; i++) 
  {
    cout<<sf(i)<<" ";
  }


  return(0);
}