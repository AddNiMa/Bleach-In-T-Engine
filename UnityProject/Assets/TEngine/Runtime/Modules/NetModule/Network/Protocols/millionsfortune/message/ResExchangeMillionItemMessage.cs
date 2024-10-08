using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 响应用百万招财积分兑换奖励消息 message
 */
public class ResExchangeMillionItemMessage : Message 
{
	//结果[0:成功,1:功能未开放,2:积分不足]
	int _result;	
	//请求兑换的奖励序号
	int _index;	
	//兑换奖励次数
	int _count;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//结果[0:成功,1:功能未开放,2:积分不足]
		SerializeUtils.WriteInt(stream, _result);
		//请求兑换的奖励序号
		SerializeUtils.WriteInt(stream, _index);
		//兑换奖励次数
		SerializeUtils.WriteInt(stream, _count);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//结果[0:成功,1:功能未开放,2:积分不足]
		_result = SerializeUtils.ReadInt(stream);
		//请求兑换的奖励序号
		_index = SerializeUtils.ReadInt(stream);
		//兑换奖励次数
		_count = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 结果[0:成功,1:功能未开放,2:积分不足]
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * 请求兑换的奖励序号
	 */
	public int Index
	{
		set { _index = value; }
	    get { return _index; }
	}
	
	/**
	 * 兑换奖励次数
	 */
	public int Count
	{
		set { _count = value; }
	    get { return _count; }
	}
	
	public override int GetId() 
	{
		return 316102;
	}
}