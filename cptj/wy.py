from collections import Counter
import sys
import os
from re import findall
global q  # 标记，q=1时为重定向方式输入
global w  # 标记，w=1时在功能1当中不输出words

def g1(book):  # 功能1：对文本进行处理，进行词频统计
    num = (0)
    if (q == 1):
        lists = findall(r'[a-z0-9^-]+', book.lower())  # 重定向方式输入时直接对字符串数据进行处理
    else:
        if os.path.splitext(book)[-1] != '.txt':  # 为输入的文章名称加上txt后缀
            book = book + '.txt'
        a = open(book, 'r', encoding='utf-8')
        lists = findall(r'[a-z0-9^-]+', a.read().lower())  # 将文本所有英文字母转变为小写，通过正则表达式对单词进行分割匹配，返回列表
    words = Counter(lists)  # Python count() 方法用于统计字符串里字符出现的次数，返回键值对字典
    for key, value in words.items():  # key为单词，value为该单词出现的次数
        num += 1
    if (w == 1):
        print('total' + ' ' + str(num))
    else:
        print('total' + ' ' + str(num) + ' ' + 'words')
    print('')
    frequentwords = words.most_common(10)  # most_common函数，统计单词出现次数，返回元组，0位为元素，1位为出现次数
    for i in frequentwords:
        print("{0:<9}\t{1:<9}\t".format(i[0], i[1]))

def g3(folder):
    novels = os.listdir(folder)  # 返回指定的文件夹包含的文件或文件夹的名字的列表
    for novel in novels:
        filename = os.path.splitext(novel)[0]  # 将文本名字与文件后缀分离
        print(filename)
        global q
        global w
        q = 0
        w = 0
        g1(folder + '/' + novel)  # 将目标文章路径传入统计函数
        print('----')

if __name__ == '__main__':
    if sys.argv[1] == '-s':
        if (len(sys.argv) == 3):
            w = 1
            q = 0
            g1(sys.argv[2])
        else:
            reword = sys.stdin.read()  # 重定向读入文本内容
            q = 1
            w = 0
            g1(reword)
    elif os.path.isdir(sys.argv[1]):  # 当输入参数是目录名时执行文件夹处理函数
        g3(sys.argv[1])
    else:
        q = 0
        w = 0
        g1(sys.argv[1])
