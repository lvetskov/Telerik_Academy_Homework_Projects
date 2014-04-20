//programm polinom elder.cpp
#include <iostream.h>
#include <iomanip.h>
#include <math.h>
#include <cstdlib>
//#include <conio.h>
#include <stdio.h>
char pp;
void stop ()
{
	cout << "Press any key & Enter to continue...";	
	cin >> pp;
//	system("PAUSE");
	return;
}
void error ()
{
	cout << "You have typed an illigal value! Try again by initiating a desired, numarical value. \n";
	cout << "Example: number '4' or '5' ";
	cout << "Press any key & Enter to continue...";
	cin >> pp;
	system("PAUSE"); //poneje ne priema vuvejdaneto na char pp;
	return;

}

int main ()
{
	cout << "1) For initialization of an equation, please type '1' \n";
	cout << "2) For initialization of a derived function, please type '2' \n" << "\n" << "Type here: ";
	int choice;
	cin >> choice;
	if (!cin)
	{	error();
		return 1;
	}
	cout << "\n";
	if (choice==1)
	{
		cout << "You have chosen the calculation of an equation \n";
	double x[19];	 
	cout << "Enter the equation's grade:  ";
	int z; 
	cin >> z;
	if (!cin)
	{	error ();
		return 1;
	}
	if ((z<1) || (z>20))
	{
		cout << "Incorrenct grade value. Try againt by typing values between 1 and 20. \n";		
	//	getch();
		stop ();
		return 1;
	}
	int bar=z;
	cout << "Enter the coefficients for every single grade: \n";
	for ( int i=z; i>=0; i--)
	{
		cout << "x" << bar << " = ";
		cin >> x[i];
		if (!cin)
	{	error();
		return 1;
	}
		bar--;
	}
	i=1;
	int kl=0;
	int p,q;
	int grade = z-1;
	if (x[0]==0)
	{
		cout << "The equation has been downgraded to " << grade; 
		switch (grade)
		{
			case 1 : cout << "st"; break;
			case 2 : cout << "nd"; break;
			default : cout << "th"; break;
		}
		cout << " grade \n";
		for ( int yy = 0; yy <= z-1 ; yy++)
		{
			x[yy] = x[i];
			i++;
			kl++;
		}
		z--;
	}		
	p=fabs(x[0]);
	q=fabs(x[z]);
	double del2[30];
	int br2=0;
	for (int a=1; a<=p; a++)
	{		
		if ((p % a)==0)
		{	br2++;
			del2[br2]=a;
	//		cout << a << "\n";
	//		br2++;
	//		del2[br2]=-a;
		}	
	}
	
	
	int br1=0;
	int del1[30];
	for (a=1; a<=q; a++)
	{	if ((q % a)==0)
		{	br1++;
			del1[br1]=a;
	//		cout << a << "\n";
	//		br1++;
	//		del1[br1]=-a;			
		}
	
	}
	int d2=br2;
	int d1=br1;
	double del[100];
	int br=0;
	br2=1;
	while (br2<=d2)
	{
		br1=1;
		while (br1<=d1)
		{
			del[br] = del2[br2] / del1[br1];
			br++;
			br1++;
			del[br] = -del[br-1];
			br++;
		}
		br2++;
	}
	cout << "The possible answers are: ";
	int aa=0;
	while (aa<br)
	{
		cout << del[aa] << ", ";
		aa++;
	}
	cout << "\n";
	br--;
	int d=br;
	br=0;
	
	int pr = 0;
	double y;
	double r;
	cout << "The roots are: \n" ;
	if (kl!=0)
		cout << "x = 0, \n" ; 
	while (br<=d)
	{
		y=0;
		r=0;
		i=z;
		while (i>=0)
		{
			y =  pow(del[br],i)*x[i];
			r=r+y;
			i--;
		} 
		if (r==0)
		{
			cout << "x = " << del[br] << "," << "\n";
			pr = pr++;
		}
		br++;
	}	
	if (pr==0)
	{
		cout << "There are no real roots!!! The equation has no resolving. \n";
		stop ();
		return 1;
	}	
	stop ();
	return 0;
	}










	if (choice==2)
	{	
			cout << "You have chosen the calculation of a derived function \n";
	double x[19];	 
	cout << "Enter the main equation's grade:  ";
	int z; 
	cin >> z;
	if (!cin)
	{	error();
		return 1;
	}
	if ((z<1) || (z>20))
	{
		cout << "Incorrenct grade value. Try againt by typing values between 1 and 20. \n";
	//	getch(); 
		if (!cin)
		error();
		return 1;
	}
	int bar=z;
	cout << "Enter the coefficients for every single grade: \n";
	for ( int i=z; i>=0; i--)
	{
		cout << "x" << bar << " = ";
		cin >> x[i];
		if (!cin)
	{	error();
		return 1;
	}
		bar--;
	}
	i=1;
	int yy = 0;
	int kl=0;
	int p,q;
	int grade = z-1;
	if (x[0]==0)
	{
		cout << "The equation has been downgraded to " << grade; 
		switch (grade)
		{
			case 1 : cout << "st"; break;
			case 2 : cout << "nd"; break;
			default : cout << "th"; break;
		}
		cout << " grade \n";
		grade --;
		for ( yy = 0; yy <= z-1 ; yy++)
		{
			x[yy] = x[i];
			i++;
		}
		z--;
	}		
		i=1;
		cout << "The equation has been downgraded to " << grade; 
		switch (grade)
		{
			case 1 : cout << "st"; break;
			case 2 : cout << "nd"; break;
			default : cout << "th"; break;
		}
		cout << " grade for the derived function to be calculated \n";
		for ( yy = 0; yy <= z-1 ; yy++)
			{
				x[yy] = x[i] * i;
				i++;
			}
		z--;
	p=fabs(x[0]);
	q=fabs(x[z]);
	double del2[30];
	int br2=0;
	for (int a=1; a<=p; a++)
	{		
		if ((p % a)==0)
		{	br2++;
			del2[br2]=a;
	//		cout << a << "\n";
	//		br2++;
	//		del2[br2]=-a;
		}	
	}
	
	
	int br1=0;
	int del1[30];
	for (a=1; a<=q; a++)
	{	if ((q % a)==0)
		{	br1++;
			del1[br1]=a;
	//		cout << a << "\n";
	//		br1++;
	//		del1[br1]=-a;			
		}
	
	}
	int d2=br2;
	int d1=br1;
	double del[100];
	int br=0;
	br2=1;
	while (br2<=d2)
	{
		br1=1;
		while (br1<=d1)
		{
			del[br] = del2[br2] / del1[br1];
			br++;
			br1++;
			del[br] = -del[br-1];
			br++;
		}
		br2++;
	}
	cout << "The possible answers are: ";
	int aa=0;
	while (aa<br)
	{
		cout << del[aa] << ", ";
		aa++;
	}
	cout << "\n";
	br--;
	int d=br;
	br=0;
	int pr = 0;
	double y;
	double r;
	cout << "The roots are: \n" ;
	while (br<=d)
	{
		y=0;
		r=0;
		i=z;
		while (i>=0)
		{
			y =  pow(del[br],i)*x[i];
			r=r+y;
			i--;
		} 
		if (r==0)
		{
			cout << "x = " << del[br] << "," << "\n";
			pr = pr++;
		}
		br++;
	}	
	if (pr==0)
	{
		cout << "There are no real roots!!! The derived function has no resolving. \n";
		stop ();
		return 1;
	}
	if (x[z]>0)
		cout << "In the right the derived function is rising and it changes alternative between the roots. \n";
		else
			cout << "In the right the derived function is lowering and it changes alternative between the roots. \n";
	}
	
	stop ();
	return 0;
	
	}
	
