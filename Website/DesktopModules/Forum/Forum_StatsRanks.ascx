<%@ Register TagPrefix="dnnforum" Namespace="DotNetNuke.Modules.Forum.WebControls" Assembly="DotNetNuke.Modules.Forum" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<%@ Register TagPrefix="dnn" TagName="SectionHead" Src="~/controls/SectionHeadControl.ascx" %>
<%@ Control language="vb" CodeBehind="Forum_StatsRanks.ascx.vb" AutoEventWireup="false" Inherits="DotNetNuke.Modules.Forum.StatsRanks" %>
<link href="<%= ForumConfig.Css() %>" type="text/css" rel="stylesheet" />
	<table class="" id="tblMain" cellspacing="0" cellpadding="0" align="center"
		width="100%">
		<tr valign="middle">
			<td class="Forum_Admin_SectionHead" valign="middle" align="left" width="100%"><dnn:sectionhead id="dshRanks" runat="server" section="tblRanks"
					resourcekey="PostRanks"></dnn:sectionhead>
				<table id="tblRanks" cellspacing="0" cellpadding="0" width="100%" runat="server">
					<tr>
						<td class="Forum_Row_AdminL" width="20%"><span class="Forum_Row_AdminText">
								<dnn:label id="plRankings" runat="server" Suffix=":" controlname="chkRatings"></dnn:label>
							</span></td>
						<td class="Forum_Row_AdminR" align="left" width="80%">
							<asp:checkbox id="chkRankings" runat="server" CssClass="Forum_NormalTextBox"></asp:checkbox></td>
					</tr>
										<tr>
						<td class="Forum_Row_AdminL" width="20%"><span class="Forum_Row_AdminText">
								<dnn:label id="plEnableRankingImage" runat="server" Suffix=":" controlname="chkEnableRankingImage"></dnn:label>
							</span></td>
						<td class="Forum_Row_AdminR" align="left" width="80%">
							<asp:checkbox id="chkEnableRankingImage" runat="server" CssClass="Forum_NormalTextBox"></asp:checkbox></td>
					</tr>
					<tr>
						<td class="Forum_Row_AdminL" width="20%"><span class="Forum_Row_AdminText"><dnn:label id="plFisrtRank" runat="server" Suffix=":" controlname="txtFisrtRank"></dnn:label>
							</span></td>
						<td class="Forum_Row_AdminR" align="left" width="80%">
                            <asp:Label ID="lbl1stCount" runat="server" CssClass="Forum_Row_AdminText" resourcekey="lblCount"></asp:Label>
                            <asp:textbox id="txtFisrtRank" runat="server" cssclass="Forum_NormalTextBox" width="50px"></asp:textbox>
                            <asp:Label ID="lbl1stTitle" runat="server" CssClass="Forum_Row_AdminText" resourcekey="lblTitle"></asp:Label>
                            <asp:TextBox ID="txt1stTitle" runat="server" CssClass="Forum_NormalTextBox"
                                Width="100px" MaxLength="25"></asp:TextBox>
                            <asp:Image ID="img1stRank" runat="server" />
                            <asp:regularexpressionvalidator id="val1st" runat="server" resourcekey="NumericValidation.ErrorMessage"
								ValidationExpression="[0-9]{1,}" ControlToValidate="txtFisrtRank" CssClass="NormalRed" Display="Dynamic"></asp:regularexpressionvalidator></td>
					</tr>
					<tr>
						<td class="Forum_Row_AdminL" width="20%"><span class="Forum_Row_AdminText"><dnn:label id="plSecondRank" runat="server" Suffix=":" controlname="txtSecondRank"></dnn:label>
							</span></td>
						<td class="Forum_Row_AdminR" align="left" width="80%">
                            <asp:Label ID="lbl2ndCount" runat="server" CssClass="Forum_Row_AdminText" resourcekey="lblCount"></asp:Label>
                            <asp:textbox id="txtSecondRank" runat="server" cssclass="Forum_NormalTextBox" width="50px"></asp:textbox>
                            <asp:Label
                                    ID="lbl2ndTitle" runat="server" CssClass="Forum_Row_AdminText" resourcekey="lblTitle"></asp:Label>
                            <asp:TextBox ID="txt2ndTitle" runat="server" CssClass="Forum_NormalTextBox"
                                Width="100px" MaxLength="25"></asp:TextBox>&nbsp;<asp:Image ID="img2ndRank" runat="server" />
                            <asp:regularexpressionvalidator id="val2nd" runat="server" resourcekey="NumericValidation.ErrorMessage"
								ValidationExpression="[0-9]{1,}" ControlToValidate="txtSecondRank" CssClass="NormalRed" Display="Dynamic"></asp:regularexpressionvalidator></td>
					</tr>
					<tr>
						<td class="Forum_Row_AdminL" width="20%"><span class="Forum_Row_AdminText"><dnn:label id="plThirdRank" runat="server" Suffix=":" controlname="txtThirdRank"></dnn:label>
							</span></td>
						<td class="Forum_Row_AdminR" align="left" width="80%">
                            <asp:Label ID="lbl3rdCount" runat="server" CssClass="Forum_Row_AdminText" resourcekey="lblCount"></asp:Label>
                            <asp:textbox id="txtThirdRank" runat="server" cssclass="Forum_NormalTextBox" width="50px"></asp:textbox>
                            <asp:Label
                                    ID="lbl3rdTitle" runat="server" CssClass="Forum_Row_AdminText" resourcekey="lblTitle"></asp:Label>
                            <asp:TextBox ID="txt3rdTitle" runat="server" CssClass="Forum_NormalTextBox"
                                Width="100px" MaxLength="25"></asp:TextBox>&nbsp;<asp:Image ID="img3rdRank" runat="server" />
                            <asp:regularexpressionvalidator id="val3rd" runat="server" resourcekey="NumericValidation.ErrorMessage"
								ValidationExpression="[0-9]{1,}" ControlToValidate="txtThirdRank" CssClass="NormalRed" Display="Dynamic"></asp:regularexpressionvalidator></td>
					</tr>
					<tr>
						<td class="Forum_Row_AdminL" width="20%"><span class="Forum_Row_AdminText"><dnn:label id="plFourthRank" runat="server" Suffix=":" controlname="txtFourthRank"></dnn:label>
							</span></td>
						<td class="Forum_Row_AdminR" align="left" width="80%">
                            <asp:Label ID="lbl4thCount" runat="server" CssClass="Forum_Row_AdminText" resourcekey="lblCount"></asp:Label>
                            <asp:textbox id="txtFourthRank" runat="server" cssclass="Forum_NormalTextBox" width="50px"></asp:textbox>
                            <asp:Label
                                    ID="lbl4thTitle" runat="server" CssClass="Forum_Row_AdminText" resourcekey="lblTitle"></asp:Label>
                            <asp:TextBox ID="txt4thTitle" runat="server" CssClass="Forum_NormalTextBox"
                                Width="100px" MaxLength="25"></asp:TextBox>&nbsp;<asp:Image ID="img4thRank" runat="server" />
                            <asp:regularexpressionvalidator id="val4th" runat="server" resourcekey="NumericValidation.ErrorMessage"
								ValidationExpression="[0-9]{1,}" ControlToValidate="txtFourthRank" CssClass="NormalRed" Display="Dynamic"></asp:regularexpressionvalidator></td>
					</tr>
					<tr>
						<td class="Forum_Row_AdminL" width="20%"><span class="Forum_Row_AdminText"><dnn:label id="plFifthRank" runat="server" Suffix=":" controlname="txtFifthRank"></dnn:label>
							</span></td>
						<td class="Forum_Row_AdminR" align="left" width="80%">
                            <asp:Label ID="lbl5thCount" runat="server" CssClass="Forum_Row_AdminText" resourcekey="lblCount"></asp:Label>
                            <asp:textbox id="txtFifthRank" runat="server" cssclass="Forum_NormalTextBox" width="50px"></asp:textbox>
                            <asp:Label
                                    ID="lbl5thTitle" runat="server" CssClass="Forum_Row_AdminText" resourcekey="lblTitle"></asp:Label>
                            <asp:TextBox ID="txt5thTitle" runat="server" CssClass="Forum_NormalTextBox"
                                Width="100px" MaxLength="25"></asp:TextBox>&nbsp;<asp:Image ID="img5thRank" runat="server" />
                            <asp:regularexpressionvalidator id="val5th" runat="server" resourcekey="NumericValidation.ErrorMessage"
								ValidationExpression="[0-9]{1,}" ControlToValidate="txtFifthRank" CssClass="NormalRed" Display="Dynamic"></asp:regularexpressionvalidator></td>
					</tr>
                    <tr>
                        <td class="Forum_Row_AdminL" width="20%"><span class="Forum_Row_AdminText">
                            <dnn:Label ID="plSixthRank" runat="server" ControlName="txtSixthRank" Suffix=":" /></span>
                        </td>
                        <td align="left" class="Forum_Row_AdminR" width="80%">
                            <asp:Label ID="lbl6thCount" runat="server" CssClass="Forum_Row_AdminText" resourcekey="lblCount"></asp:Label>
                            <asp:TextBox ID="txtSixthRank" runat="server" CssClass="Forum_NormalTextBox"
                                Width="50px"></asp:TextBox>
                            <asp:Label
                                    ID="lbl6thTitle" runat="server" CssClass="Forum_Row_AdminText" resourcekey="lblTitle"></asp:Label>
                            <asp:TextBox ID="txt6thTitle" runat="server" CssClass="Forum_NormalTextBox"
                                Width="100px" MaxLength="25"></asp:TextBox>&nbsp;<asp:Image ID="img6thRank" runat="server" />
                            <asp:RegularExpressionValidator ID="val6th" runat="server" ControlToValidate="txtSixthRank"
                                CssClass="NormalRed" resourcekey="NumericValidation.ErrorMessage"
                                ValidationExpression="[0-9]{1,}" Display="Dynamic"></asp:RegularExpressionValidator></td>
                    </tr>
                    <tr>
                        <td class="Forum_Row_AdminL" width="20%"><span class="Forum_Row_AdminText">
                            <dnn:Label ID="plSeventhRank" runat="server" ControlName="txtSeventhRank" Suffix=":" /></span>
                        </td>
                        <td align="left" class="Forum_Row_AdminR" width="80%">
                            <asp:Label ID="lbl7thCount" runat="server" CssClass="Forum_Row_AdminText" resourcekey="lblCount"></asp:Label>
                            <asp:TextBox ID="txtSeventhRank" runat="server" CssClass="Forum_NormalTextBox"
                                Width="50px"></asp:TextBox>
                            <asp:Label
                                    ID="lbl7thTitle" runat="server" CssClass="Forum_Row_AdminText" resourcekey="lblTitle"></asp:Label>
                            <asp:TextBox ID="txt7thTitle" runat="server" CssClass="Forum_NormalTextBox"
                                Width="100px" MaxLength="25"></asp:TextBox>&nbsp;<asp:Image ID="img7thRank" runat="server" />
                            <asp:RegularExpressionValidator ID="val7th" runat="server" ControlToValidate="txtSeventhRank"
                                CssClass="NormalRed" resourcekey="NumericValidation.ErrorMessage"
                                ValidationExpression="[0-9]{1,}" Display="Dynamic"></asp:RegularExpressionValidator></td>
                    </tr>
                    <tr>
                        <td class="Forum_Row_AdminL" width="20%"><span class="Forum_Row_AdminText">
                            <dnn:Label ID="plEigthRank" runat="server" ControlName="txtEigthRank" Suffix=":" /></span>
                        </td>
                        <td align="left" class="Forum_Row_AdminR" width="80%">
                            <asp:Label ID="lbl8thCount" runat="server" CssClass="Forum_Row_AdminText" resourcekey="lblCount"></asp:Label>
                            <asp:TextBox ID="txtEigthRank" runat="server" CssClass="Forum_NormalTextBox"
                                Width="50px"></asp:TextBox>
                            <asp:Label
                                    ID="lbl8thTitle" runat="server" CssClass="Forum_Row_AdminText" resourcekey="lblTitle"></asp:Label>
                            <asp:TextBox ID="txt8thTitle" runat="server" CssClass="Forum_NormalTextBox"
                                Width="100px" MaxLength="25"></asp:TextBox>&nbsp;<asp:Image ID="img8thRank" runat="server" />
                            <asp:RegularExpressionValidator ID="val8th" runat="server" ControlToValidate="txtEigthRank"
                                CssClass="NormalRed" resourcekey="NumericValidation.ErrorMessage"
                                ValidationExpression="[0-9]{1,}" Display="Dynamic"></asp:RegularExpressionValidator></td>
                    </tr>
                    <tr>
                        <td class="Forum_Row_AdminL" width="20%"><span class="Forum_Row_AdminText">
                            <dnn:Label ID="plNinthRank" runat="server" ControlName="txtNinthRank" Suffix=":" /></span>
                        </td>
                        <td align="left" class="Forum_Row_AdminR" width="80%">
                            <asp:Label ID="lbl9thCount" runat="server" CssClass="Forum_Row_AdminText" resourcekey="lblCount"></asp:Label>
                            <asp:TextBox ID="txtNinthRank" runat="server" CssClass="Forum_NormalTextBox"
                                Width="50px"></asp:TextBox>
                            <asp:Label
                                    ID="lbl9thTitle" runat="server" CssClass="Forum_Row_AdminText" resourcekey="lblTitle"></asp:Label>
                            <asp:TextBox ID="txt9thTitle" runat="server" CssClass="Forum_NormalTextBox"
                                Width="100px" MaxLength="25"></asp:TextBox>&nbsp;<asp:Image ID="img9thRank" runat="server" />
                            <asp:RegularExpressionValidator ID="val9th" runat="server"
                                ControlToValidate="txtNinthRank" CssClass="NormalRed"
                                resourcekey="NumericValidation.ErrorMessage" ValidationExpression="[0-9]{1,}" Display="Dynamic"></asp:RegularExpressionValidator></td>
                    </tr>
                    <tr>
                        <td class="Forum_Row_AdminL" width="20%"><span class="Forum_Row_AdminText">
                            <dnn:Label ID="plTenthRank" runat="server" ControlName="txtTenthRank" Suffix=":" /></span>
                        </td>
                        <td align="left" class="Forum_Row_AdminR" width="80%">
                            <asp:Label ID="lbl10thCount" runat="server" CssClass="Forum_Row_AdminText" resourcekey="lblCount"></asp:Label>
                            <asp:TextBox ID="txtTenthRank" runat="server" CssClass="Forum_NormalTextBox"
                                Width="50px"></asp:TextBox>
                            <asp:Label
                                    ID="lbl10thTitle" runat="server" CssClass="Forum_Row_AdminText" resourcekey="lblTitle"></asp:Label>
                            <asp:TextBox ID="txt10thTitle" runat="server" CssClass="Forum_NormalTextBox"
                                Width="100px" MaxLength="25"></asp:TextBox>&nbsp;<asp:Image ID="img10thRank" runat="server" />
                            <asp:RegularExpressionValidator ID="val10th" runat="server"
                                ControlToValidate="txtTenthRank" CssClass="NormalRed"
                                resourcekey="NumericValidation.ErrorMessage" ValidationExpression="[0-9]{1,}" Display="Dynamic"></asp:RegularExpressionValidator></td>
                    </tr>
                                        <tr>
                        <td class="Forum_Row_AdminL" width="20%"><span class="Forum_Row_AdminText">
                            <dnn:Label ID="plNoRanking" runat="server" ControlName="txtNoRanking" Suffix=":" /></span>
                        </td>
                        <td align="left" class="Forum_Row_AdminR" width="80%">
                            <asp:Label ID="lblNoCount" runat="server" CssClass="Forum_Row_AdminText" resourcekey="lblCount"></asp:Label>
                            <asp:TextBox ID="txtNoRanking" runat="server" CssClass="Forum_NormalTextBox"
                                Width="50px" Enabled="False"></asp:TextBox>
                            <asp:Label
                                    ID="lblNoTitle" runat="server" CssClass="Forum_Row_AdminText" resourcekey="lblTitle"></asp:Label>
                            <asp:TextBox ID="txtNoRankTitle" runat="server" CssClass="Forum_NormalTextBox"
                                Width="100px" MaxLength="25"></asp:TextBox>&nbsp;<asp:Image ID="imgNoRank" runat="server" />
                    </tr>
				</table>
			</td>
		</tr>
				<tr valign="middle">
			<td class="Forum_Admin_SectionHead" valign="middle" align="left" width="100%"><dnn:sectionhead id="dshPopular" runat="server" section="tblPopular" resourcekey="dshPopular" isExpanded="False"></dnn:sectionhead>
				<table id="tblPopular" cellspacing="0" cellpadding="0" width="100%" runat="server">
					<tr>
						<td class="Forum_Row_AdminL" width="20%"><span class="Forum_Row_AdminText">
                            <dnn:Label ID="plPopularPostsView" runat="server" ControlName="txtPopularThreadView"
                                Suffix=":" />
							</span></td>
						<td class="Forum_Row_AdminR" valign="middle" align="left" width="80%">
                            <asp:TextBox ID="txtPopularThreadView" runat="server" CssClass="Forum_NormalTextBox"
                                Width="180px"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="Regularexpressionvalidator12" runat="server"
                                ControlToValidate="txtPopularThreadView" CssClass="Forum_NormalTextBox" ErrorMessage="Needs to be numeric!"
                                resourcekey="NumericValidation.ErrorMessage" ValidationExpression="[0-9]{1,}"></asp:RegularExpressionValidator></td>
					</tr>
					<tr>
						<td class="Forum_Row_AdminL" width="20%"><span class="Forum_Row_AdminText">
                            <dnn:Label ID="plPopularPostsReply" runat="server" ControlName="txtPopularThreadReply"
                                Suffix=":" />
							</span></td>
						<td class="Forum_Row_AdminR" align="left" width="80%">
                            <asp:TextBox ID="txtPopularThreadReply" runat="server" CssClass="Forum_NormalTextBox"
                                Width="180px"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="Regularexpressionvalidator13" runat="server"
                                ControlToValidate="txtPopularThreadReply" CssClass="Forum_NormalTextBox" ErrorMessage="Needs to be numeric!"
                                resourcekey="NumericValidation.ErrorMessage" ValidationExpression="[0-9]{1,}"></asp:RegularExpressionValidator></td>
					</tr>
				</table>
			</td>
		</tr>
		<tr>
			<td class="Forum_Admin_SectionHead" valign="middle" align="left" width="100%">
				<dnn:sectionhead id="dshRatings" runat="server" section="tblRatings" resourcekey="Ratings" isExpanded="False"></dnn:sectionhead>
				<table id="tblRatings" cellspacing="0" cellpadding="0" width="100%" runat="server">
					<tr>
						<td class="Forum_Row_AdminL" width="20%"><span class="Forum_Row_AdminText">
									<dnn:label id="plRatings" runat="server" Suffix=":" controlname="chkRatings"></dnn:label>
								</span>
							</td>
						<td class="Forum_Row_AdminR" valign="middle" align="left" width="80%"><asp:checkbox id="chkRatings" runat="server" CssClass="Forum_NormalTextBox"></asp:checkbox></td>
					</tr>
                    <tr>
                        <td class="Forum_Row_AdminL" width="20%"><span class="Forum_Row_AdminText">
                            <dnn:Label ID="pl1stRating" runat="server" ControlName="txt1stRating" Suffix=":" /></span>
                        </td>
                        <td align="left" class="Forum_Row_AdminR" valign="middle" width="80%">
                            <table border="0" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td>
                            <asp:TextBox ID="txt1stRating" runat="server" CssClass="Forum_NormalTextBox" MaxLength="50"
                                Width="180px"></asp:TextBox>&nbsp;</td>
                                    <td>
                            <asp:Image ID="img1stRating" runat="server" /></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td class="Forum_Row_AdminL" width="20%"><span class="Forum_Row_AdminText">
                            <dnn:Label ID="pl2ndRating" runat="server" ControlName="txt2ndRating" Suffix=":" /></span>
                        </td>
                        <td align="left" class="Forum_Row_AdminR" valign="middle" width="80%">
                            <table border="0" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td>
                            <asp:TextBox ID="txt2ndRating" runat="server" CssClass="Forum_NormalTextBox" MaxLength="50"
                                Width="180px"></asp:TextBox>&nbsp;</td>
                                    <td>
                            <asp:Image ID="img2ndRating" runat="server" /></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td class="Forum_Row_AdminL" width="20%"><span class="Forum_Row_AdminText">
                            <dnn:Label ID="pl3rdRating" runat="server" ControlName="txt3rdRating" Suffix=":" /></span>
                        </td>
                        <td align="left" class="Forum_Row_AdminR" valign="middle" width="80%">
                            <table border="0" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td>
                            <asp:TextBox ID="txt3rdRating" runat="server" CssClass="Forum_NormalTextBox" MaxLength="50"
                                Width="180px"></asp:TextBox>&nbsp;</td>
                                    <td>
                            <asp:Image ID="img3rdRating" runat="server" /></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td class="Forum_Row_AdminL" width="20%"><span class="Forum_Row_AdminText">
                            <dnn:Label ID="pl4thRating" runat="server" ControlName="txt4thRating" Suffix=":" /></span>
                        </td>
                        <td align="left" class="Forum_Row_AdminR" valign="middle" width="80%">
                            <table border="0" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td>
                            <asp:TextBox ID="txt4thRating" runat="server" CssClass="Forum_NormalTextBox" MaxLength="50"
                                Width="180px"></asp:TextBox>&nbsp;</td>
                                    <td>
                            <asp:Image ID="img4thRating" runat="server" /></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td class="Forum_Row_AdminL" width="20%"><span class="Forum_Row_AdminText">
                            <dnn:Label ID="pl5thRating" runat="server" ControlName="txt5thRating" Suffix=":" /></span>
                        </td>
                        <td align="left" class="Forum_Row_AdminR" valign="middle" width="80%">
                            <table border="0" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td>
                            <asp:TextBox ID="txt5thRating" runat="server" CssClass="Forum_NormalTextBox" MaxLength="50"
                                Width="180px"></asp:TextBox>&nbsp;</td>
                                    <td>
                            <asp:Image ID="img5thRating" runat="server" /></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td class="Forum_Row_AdminL" width="20%"><span class="Forum_Row_AdminText">
                            <dnn:Label ID="pl6thRating" runat="server" ControlName="txt6thRating" Suffix=":" /></span>
                        </td>
                        <td align="left" class="Forum_Row_AdminR" valign="middle" width="80%">
                            <table border="0" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td>
                            <asp:TextBox ID="txt6thRating" runat="server" CssClass="Forum_NormalTextBox" MaxLength="50"
                                Width="180px"></asp:TextBox>&nbsp;</td>
                                    <td>
                            <asp:Image ID="img6thRating" runat="server" /></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td class="Forum_Row_AdminL" width="20%"><span class="Forum_Row_AdminText">
                            <dnn:Label ID="pl7thRating" runat="server" ControlName="txt7thRating" Suffix=":" /></span>
                        </td>
                        <td align="left" class="Forum_Row_AdminR" valign="middle" width="80%">
                              <table border="0" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td>
                            <asp:TextBox ID="txt7thRating" runat="server" CssClass="Forum_NormalTextBox" MaxLength="50"
                                Width="180px"></asp:TextBox>&nbsp;</td>
                                    <td>
                            <asp:Image ID="img7thRating" runat="server" /></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td class="Forum_Row_AdminL" width="20%"><span class="Forum_Row_AdminText">
                            <dnn:Label ID="pl8thRating" runat="server" ControlName="txt8thRating" Suffix=":" /></span>
                        </td>
                        <td align="left" class="Forum_Row_AdminR" valign="middle" width="80%">
                            <table border="0" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td>
                            <asp:TextBox ID="txt8thRating" runat="server" CssClass="Forum_NormalTextBox" MaxLength="50"
                                Width="180px"></asp:TextBox>&nbsp;</td>
                                    <td>
                            <asp:Image ID="img8thRating" runat="server" /></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td class="Forum_Row_AdminL" width="20%"><span class="Forum_Row_AdminText">
                            <dnn:Label ID="pl9thRating" runat="server" ControlName="txt9thRating" Suffix=":" /></span>
                        </td>
                        <td align="left" class="Forum_Row_AdminR" valign="middle" width="80%">
                            <table border="0" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td>
                            <asp:TextBox ID="txt9thRating" runat="server" CssClass="Forum_NormalTextBox" MaxLength="50"
                                Width="180px"></asp:TextBox>&nbsp;</td>
                                    <td>
                            <asp:Image ID="img9thRating" runat="server" /></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td class="Forum_Row_AdminL" width="20%"><span class="Forum_Row_AdminText">
                            <dnn:Label ID="pl10thRating" runat="server" ControlName="txt10thRating" Suffix=":" /></span>
                        </td>
                        <td align="left" class="Forum_Row_AdminR" valign="middle" width="80%">
                            <table border="0" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td>
                            <asp:TextBox ID="txt10thRating" runat="server" CssClass="Forum_NormalTextBox" MaxLength="50"
                                Width="180px"></asp:TextBox>&nbsp;</td>
                                    <td>
                            <asp:Image ID="img10thRating" runat="server" /></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
				</table>
			</td>
		</tr>
		<tr>
			<td class="Forum_Row_Admin_Foot" align="center" width="100%">
							<asp:linkbutton cssclass="CommandButton" id="cmdUpdate" runat="server" text="Update" resourcekey="cmdUpdate"></asp:linkbutton>&nbsp;
							<asp:linkbutton cssclass="CommandButton" id="cmdCancel" runat="server" text="Cancel" resourcekey="cmdCancel"
								CausesValidation="False"></asp:linkbutton>
						</td>
		</tr>
	</table>
