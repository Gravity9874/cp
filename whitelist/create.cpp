#include <iostream>
#include <stdlib.h>
#include <time.h>

using namespace std;

int main(int argc, char* argv[])
{
    int num = atoi(argv[1]);     //ʹ��atoi�������ַ�������ת��Ϊ����
    srand((unsigned)time(NULL));
    for (int i = 0; i < num; i++)
    {
        cout << rand() << "\n";
    }
    cout << endl;
    return 0;
}
