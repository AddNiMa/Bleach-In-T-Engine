using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 通知前端跨天重置签到信息，需要通从服务器获得的时间自行计算是否已经跨月，跨月需要重置当月所有的签到信息 message
 */
public class ResResetSigninMessage : Message 
{
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
	}
	
	
	public override int GetId() 
	{
		return 305102;
	}
}