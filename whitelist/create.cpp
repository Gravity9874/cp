#include <iostream>
#include <stdlib.h>
#include <time.h>

using namespace std;

int main(int argc, char* argv[])
{
    int num = atoi(argv[1]);     //使用atoi函数将字符串参数转换为整型
    srand((unsigned)time(NULL));
    for (int i = 0; i < num; i++)
    {
        cout << rand() << "\n";
    }
    cout << endl;
    return 0;
}
