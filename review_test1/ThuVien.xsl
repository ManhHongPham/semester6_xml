<?xml version="1.0" encoding="UTF-8"?>

<!--
    Document   : ThuVien.xsl
    Created on : July 11, 2021, 10:18 PM
    Author     : manh
    Description:
        Purpose of transformation follows.
-->

<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
    <xsl:output method="html"/>

    <!-- TODO customize transformation rules 
         syntax recommendation http://www.w3.org/TR/xslt 
    -->
    <xsl:template match="/">
        <html>
            <head>
                <title>ThuVien.xsl</title>
            </head>
            <body>
                <h1>DANH MỤC SÁCH</h1>
                <xsl:for-each select="DS/TV">
                    <H3>thư viên: <xsl:value-of select="@TenTV"/></H3>
                    <xsl:for-each select="nhaxuatban">
                        <h3>
                            Mã nhà xuất bản: <xsl:value-of select="@MaNXB"/>
                        </h3>
                        <h3>
                            Nhà xuất bản: <xsl:value-of select="tennhaxuatban"/>
                        </h3>
                        <table>
                            <tr>
                                <th>STT</th>
                                <th>Tên sách</th>
                                <th>Thể loại</th>
                                <th>Số trang</th>
                                <th>Giá</th>
                            </tr>
                            <xsl:for-each select="sach">
                                <tr>
                                    <td>
                                        <xsl:number value="position()" format="1."/>
                                    </td>
                                    <td>
                                        <xsl:value-of select="tensach"/>
                                    </td>
                                    <td>
                                        <xsl:value-of select="theloai"/>
                                    </td>
                                    <td>
                                        <xsl:value-of select="@sotrang"/>
                                    </td>
                                    <td>
                                        <xsl:variable name="ST" select="@sotrang"/>
                                        
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

</xsl:stylesheet>
