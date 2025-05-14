#include <iostream>
using namespace std;
int delta(int A,int B,int C)
{
     int DELTA = (B*B)- (4*A*C);
     return DELTA;
}
int Finalxi(int delta, int A , int B)
{
    int xi = ((-B) + (delta^1/2))/2*A ;
    return xi;
}
int Finalxii(int delta, int A , int B )
{
    int xii = ((-B) - (delta^1/2))/2*A ;
    return xii;
}
int main()
{
   int A,B,C,i,XI,XII,DELTA;
   for (i=0;i<3;i++)
   {
       switch (i)
       {
       case 0:
       cout << "Please Enter A: " << endl;
       cin >> A ;
        break;
       case 1:
       cout << "Please Enter B: " << endl;
       cin >> B ;
        break;
       case 2:
       cout << "Please Enter C: " << endl;
       cin >> C ;
        break;
       }
   }
 DELTA = delta(A,B,C);
 if (A==0)
 {
    cout<<"Your function is single-variable."<<endl;
 }
 if (DELTA < 0)
 {
     cout<<"Your function has no answer"<<endl;
 }
 else
 {
      XI = Finalxi(DELTA,A,B);
      XII = Finalxii(DELTA,A,B);
      cout<<"X1 is :" + XI <<endl;
      cout<<"X2 is :" + XII <<endl;
 }
return 0;
}


