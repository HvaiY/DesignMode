using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeMode
{
    /// <summary>
    /// 组合模式:  以前是一次性描述一个整体，一个复杂的对象，但是由于层级是无限的，根本无法描述
    /// 组合模式是对重复点的抽取，讲整个对象化整为零，分层描述，
    /// 递归查找
    /// </summary>
    class Program
    {
        //递归

        /// <summary>
        /// 找出文件夹里面所有的文件，放入fileList
        /// </summary>
        /// <param name="dir"></param>
        /// <param name="fileList"></param>
        /// <returns></returns>
        private static void GetChildFileList(DirectoryInfo dir, List<FileInfo> fileList)
        {
            fileList.AddRange(dir.GetFiles());//找出该文件夹下面的所有文件
            List<DirectoryInfo> dirList = dir.GetDirectories().ToList();//找出所有的文件夹
            
            foreach (DirectoryInfo dirChild in dirList)//循环文件夹
            {
                GetChildFileList(dirChild, fileList);//找出文件夹里面所有的文件，放入fileList
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("欢迎大家来到.net高级班公开课程,这里是Eleven's设计模式特训课");

            DirectoryInfo rootDirectory = new DirectoryInfo(@"E:\online5");
            List<FileInfo> fileList = new List<FileInfo>();
            GetChildFileList(rootDirectory, fileList);
            Console.WriteLine("一共是{0}个", fileList.Count());

            //fileList.AddRange(rootDirectory.GetFiles());//获取文件夹下面的文件

            //DirectoryInfo[] childDir = rootDirectory.GetDirectories();

            //foreach (DirectoryInfo dir in childDir)
            //{
            //    fileList.AddRange(dir.GetFiles());
            //    DirectoryInfo[] childDir1 = dir.GetDirectories();
            //    foreach (DirectoryInfo dir1 in childDir1)
            //    {
            //        fileList.AddRange(dir1.GetFiles());
            //        DirectoryInfo[] childDir2 = dir1.GetDirectories();
            //    }
            //}





















            //复杂对象   容器对象
            MyProject myProject = new MyProject()
            {
                DirectoryList = new List<MyDirectory>()
                {
                    new MyDirectory()
                    {
                        Name="bin"
                    },
                    new MyDirectory()
                    {
                        Name="obj"
                    },
                    new MyDirectory()
                    {
                        Name="Properties"
                    }
                },
                FileList = new List<MyFile>() 
                { 
                    new MyFile()
                    {
                        Name="App.config"
                    },
                }
            };
            //myProject.DirectoryList


            MyNode myNode = new MyNode()
            {
                Path = @"E:\OpenCourse\designmode\8 Composite\CompositeMode\CompositeMode"
            };
            myNode.GetMyDirectoryList();

            //myNode.MyFileList;

            Console.Read();
        }
    }
}
