using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求吃特供料理消息 message
 */
public class ReqEatSpecialFoodMessage : Message 
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
		return 106204;
	}
}