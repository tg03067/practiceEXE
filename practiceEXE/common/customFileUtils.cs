using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceEXE.common
{
    public class customFileUtils
    {
        public string uploadPath ;

        public customFileUtils(string uploadPath = @"C:\pratice")
        {
            this.uploadPath = uploadPath;
        }

        // 폴더 만들기
        public string makeFolder(string path)
        {
            // 해당 위치에 폴더가 없으면 폴더 만들기
            string folder = Path.Combine(uploadPath, path);
            DirectoryInfo di = new DirectoryInfo(folder);

            if (!di.Exists)
            {
                di.Create();
            }

            return di.FullName;
        }

        // GUID 사용 랜덤 파일명
        public string makeRandomFileName()
        {
            return Guid.NewGuid().ToString() ;
        }

        // 파일명 확장자 가져오기
        public string getExt(string fileName)
        {
            // 파일 확장자 추출 메서드
            return Path.GetExtension(fileName) ;
        }

        // 랜덤 파일명 with 확장자 만들기
        public string makeRandomFileName(string fileName)
        {
            // fileName 원본에 확장자 랜덤한 파일명 리턴
            return makeRandomFileName() + getExt(fileName);
        }

        // 이미지 저장
        public void saveImageToPath(PictureBox pictureBox, string filePath)
        {
            if(pictureBox.Image != null)
            {
                // 경로 조합 및 경로 확인
                string fullPath = Path.Combine(uploadPath, filePath);
                MessageBox.Show($"저장할 경로: {fullPath}");

                using (Image imageCopy = new Bitmap(pictureBox.Image)) // Bitmap으로 복사하여 저장
                {
                    imageCopy.Save(fullPath, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
            else
            {
                MessageBox.Show("문제 발생");
                return;
            }
        }

        // 폴더 삭제
        public void deleteFolder(string absoluteFolderPath)
        {
            DirectoryInfo folder = new DirectoryInfo(absoluteFolderPath);
            if (folder.Exists)
            {
                DirectoryInfo[] dirs = folder.GetDirectories();

                // 파일을 먼저 삭제
                foreach (FileInfo file in folder.GetFiles())
                {
                    file.Delete();
                }

                // 하위 디렉토리를 재귀적으로 삭제
                foreach(DirectoryInfo dir in folder.GetDirectories())
                {
                    deleteFolder(dir.FullName);
                }

                // 모든 파일과 하위 폴더가 삭제된 후 상위 폴더 삭제
                folder.Delete();
            }
        }
    }
}
