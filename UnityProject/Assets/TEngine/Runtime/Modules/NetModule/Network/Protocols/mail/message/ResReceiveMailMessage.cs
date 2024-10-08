using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 收到邮件 message
 */
public class ResReceiveMailMessage : Message 
{
	//收到的邮件的具体信息
	MailInfo _mailInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//收到的邮件的具体信息
		SerializeUtils.WriteBean(stream, _mailInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//收到的邮件的具体信息
		_mailInfo = SerializeUtils.ReadBean<MailInfo>(stream);
	}
	
	/**
	 * 收到的邮件的具体信息
	 */
	public MailInfo MailInfo
	{
		set { _mailInfo = value; }
	    get { return _mailInfo; }
	}
	
	
	public override int GetId() 
	{
		return 500104;
	}
}