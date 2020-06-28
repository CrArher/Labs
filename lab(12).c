#include <iostream>
#include <fstream>
#include <string>
#include <cstring>

struct Worker
{
    char Name[50];
    char Post[25];
    int  Year;
};

void InputData(Worker *lrh,int len);
void OutAllData(Worker *lrh,int len);
void OutYearData(Worker *lrh,int year,int len);
void SelectSort(Worker *lrh, int len);

int main(int argc, char *argv[])
{
    const int  col = 10;
    int year;
    Worker TABL[col];

    InputData(Sheet,col);
    cout<<endl;
    SelectSort(Sheet,col);
    OutAllData(Sheet,col);
    cout<<endl;
    cout<<"Input year: "; cin>>year;
    OutYearData(Sheet,year,col);

    return 0;
}

void InputData(Worker *lrh,int len)
{
    for(int i = 0; i < len; ++i)
    {
        cout<<"Input Worker["<<i+1<<"]\nName: "; _flushall();  cin.getline(lrh[i].Name,50);
        cout<<"Post: "; cin>>lrh[i].Post;
        cout<<"Year: "; cin>>lrh[i].Year;
    }

}

void OutAllData(Worker *lrh,int len)
{

    for(int i = 0; i < len; ++i)
    {
        cout<<"Out Worker["<<i+1<<"]\nName: "<<lrh[i].Name<<endl
            <<"Post: "<<lrh[i].Post<<endl
            <<"Year: "<<lrh[i].Year<<endl;
    }
}

void OutYearData(Worker *lrh,int year,int len)
{
    bool flag = false;
    for(int i = 0; i < len; ++i)
    {
        if(year < lrh[i].Year)
        {
            flag = true;
            cout<<"Out Worker["<<i+1<<"]\nName: "<<lrh[i].Name<<endl
                <<"Post: "<<lrh[i].Post<<endl
                <<"Year: "<<lrh[i].Year<<endl;
        }
    }

    if(flag == false)
        cout<<"Sorry :)"<<endl;
}
int compare(const Worker* struct1,const Worker* struct2)
{
    int result;
    result = strcmp(struct1->Name,struct2->Name);
    return result;

}
void Fack(Worker *l, Worker *r)
{
    strcpy(l->Post,r->Post);
    strcpy(l->Name,r->Name);
    l->Year = r->Year;
}
void SelectSort(Worker *lrh, int len) {
    int k;
    Worker x;
    for( int i=0; i < len; i++)
    {
        k = i;
        Fack(&x,&lrh[i]);
        for(int j = i + 1; j < len; j++)
            if(compare(&lrh[j],&x))
            {
                k = j;
                Fack(&x,&lrh[j]);
            }
        Fack(&lrh[k],&lrh[i]);
        Fack(&lrh[i],&x);
    }
}
