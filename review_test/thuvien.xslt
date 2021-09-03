<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <xsl:output method="html" indent="yes"/>

  <xsl:template match="/">
    <!--<xsl:template match="Sach">-->
    <html>
      <body>
        <h1 align="center">DANH MỤC SÁCH</h1>
        <xsl:for-each select="DS/TV">
          <h3>
            Thư viện: <xsl:value-of select="@TenTV"/>
          </h3>
          <xsl:for-each select="NXB">
            <h3>
              Mã nhà xuất bản: <xsl:value-of select="@MaNXB"/>
            </h3>
            <h3>
              Nhà xuất bản: <xsl:value-of select="TenNXB"/>
            </h3>
            <table border="2" width="100%" cellspacing="0">
              <tr>
                <th>STT</th>
                <th>Tên sách</th>
                <th>Thể loại</th>
                <th>Số trang</th>
                <th>Giá</th>
              </tr>


              <xsl:for-each select="Sach">
                <tr>
                  <td>
                    <xsl:value-of select="position()"/>
                  </td>
                  <td>
                    <xsl:value-of select="TenSach"/>
                  </td>
                  <td>
                    <xsl:value-of select="TheLoai"/>
                  </td>
                  <td>
                    <xsl:value-of select="@SoTrang"/>
                  </td>
                  <td>
                    <xsl:variable name="ST" select="@SoTrang"/>
                    <xsl:if test=" $ST &lt;= 100">
                      <xsl:value-of select="$ST * 5000"/>
                    </xsl:if>

                    <xsl:if test=" $ST &gt;100 and $ST &gt;= 150">
                      <xsl:value-of select="100 * 5000 + ($ST - 100) * 4000"/>
                    </xsl:if>

                    <xsl:if test="$ST &gt; 150 and $ST &lt;=200">
                      <xsl:value-of select="100 * 5000 + 50 * 4000 + ($ST - 150) * 3000"/>
                    </xsl:if>

                    <xsl:if test=" $ST &gt; 200">
                      <xsl:value-of select="100 * 5000 + 50 * 4000 + 50 * 3000 + ($ST - 200) * 2000"/>
                    </xsl:if>
                  </td>

                </tr>

              </xsl:for-each>

            </table>
          </xsl:for-each>
        </xsl:for-each>

      </body>
    </html>
  </xsl:template>
  <!--</xsl:template>-->
</xsl:stylesheet>
