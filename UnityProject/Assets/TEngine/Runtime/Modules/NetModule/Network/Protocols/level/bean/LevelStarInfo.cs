using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 通关星级信息
 */
public class LevelStarInfo : IMessageSerialize 
{
	//当前关卡星级数量
	int _star;	
	//关卡所有星级之和
	int _totalStar;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//当前关卡星级数量
		SerializeUtils.WriteInt(stream, _star);
		//关卡所有星级之和
		SerializeUtils.WriteInt(stream, _totalStar);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//当前关卡星级数量
		_star = SerializeUtils.ReadInt(stream);
		//关卡所有星级之和
		_totalStar = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 当前关卡星级数量
	 */
	public int Star
	{
		set { _star = value; }
	    get { return _star; }
	}
	
	/**
	 * 关卡所有星级之和
	 */
	public int TotalStar
	{
		set { _totalStar = value; }
	    get { return _totalStar; }
	}
	
}